using System.Drawing;

namespace ParticleFilterTraking.Backend
{
    interface ITrackedObject
    {
        bool Contains(Position position);
        Position Move();
        void Draw(Bitmap canvas);
    }
}
