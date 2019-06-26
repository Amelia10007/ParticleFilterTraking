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
            this.field.ObservationTarget.Draw(bitmap);
            this.estimator.DrawEstimation(bitmap);
            return bitmap;
        }
    }
}
