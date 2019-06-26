namespace ParticleFilterTraking.Backend
{
    class Particle
    {
        public Position Position { get; set; }
        public Particle(Position initialPosition) => this.Position = initialPosition;
    }
}
