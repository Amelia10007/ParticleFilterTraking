namespace ParticleFilterTraking.Backend
{
    class Field
    {
        public readonly Size Size;
        public readonly ITrackedObject ObservationTarget;
        public Field(Size size, ITrackedObject target)
        {
            this.Size = size;
            this.ObservationTarget = target;
        }
        public Position UpdateAndGetMovement() => this.ObservationTarget.Move();
    }
}
