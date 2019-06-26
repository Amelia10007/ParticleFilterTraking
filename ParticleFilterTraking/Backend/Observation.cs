namespace ParticleFilterTraking.Backend
{
    class Observation
    {
        private readonly Field field;
        private readonly double wrongRate;
        public readonly Position TargetMovement;
        public Observation(Field field, double wrongRate, Position targetMovement)
        {
            this.field = field;
            this.wrongRate = wrongRate;
            this.TargetMovement = targetMovement;
        }
        public double ProbabilityAt(Position position) => this.field.ObservationTarget.Contains(position) ? (1 - this.wrongRate) : this.wrongRate;
    }
}
