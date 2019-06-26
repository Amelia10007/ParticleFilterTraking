using System.Drawing;

namespace ParticleFilterTraking.Backend
{
    interface IEstimator
    {
        void UpdateEstimation(Observation observation);
        void DrawEstimation(Bitmap canvas);
    }
}
