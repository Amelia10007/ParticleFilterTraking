using System.Drawing;

namespace ParticleFilterTraking.Backend
{
    class BackendSystem
    {
        private readonly Field field;
        private readonly IEstimator estimator;
        private readonly double observationWrongRate;
        public BackendSystem(Field field, IEstimator estimator, double observationWrongRate)
        {
            this.field = field;
            this.estimator = estimator;
            this.observationWrongRate = observationWrongRate;
        }
        public void Update()
        {
            var movement = this.field.UpdateAndGetMovement();
            var observation = new Observation(this.field, this.observationWrongRate, movement);
            this.estimator.UpdateEstimation(observation);
        }
        public Bitmap Draw()
        {
            var bitmap = new Bitmap(this.field.Size.Width, this.field.Size.Height);
            using(var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.Black);
            }
            this.field.ObservationTarget.Draw(bitmap);
            this.estimator.DrawEstimation(bitmap);
            return bitmap;
        }
        public override string ToString() => $"Estimator: {this.estimator.ToString()}";
    }
}
