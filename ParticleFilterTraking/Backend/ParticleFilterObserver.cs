using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace ParticleFilterTraking.Backend
{
    class ParticleFilterObserver : IEstimator
    {
        private class ProbabilityCell
        {
            public readonly Position Position;
            public readonly double ProbabilitySum;
            public ProbabilityCell(Position position, double probabilitySum)
            {
                this.Position = position;
                this.ProbabilitySum = probabilitySum;
            }
        }
        private readonly Size size;
        private IReadOnlyCollection<Particle> particles;
        public ParticleFilterObserver(Field field, int particleCount)
        {
            this.size = field.Size;
            var list = new List<Particle>(particleCount);
            var random = new Random();
            //最初のステップでは，全粒子はランダムに散らばっている
            for (int i = 0; i < particleCount; i++)
            {
                var x = random.Next(field.Size.Width);
                var y = random.Next(field.Size.Height);
                var position = new Position(x, y);
                list.Add(new Particle(position));
            }
            this.particles = list;
        }
        public void UpdateEstimation(Observation observation)
        {
            //観測対象物体の移動量に合わせて，すべての粒子を移動させる．
            var movedParticleGroup =
                (from particle in this.particles.AsParallel()
                 let movedPosition = (particle.Position + observation.TargetMovement)
                    .Let(p => p.ChangeX(p.X.Round(0, this.size.Width - 1)))
                    .Let(p => p.ChangeY(p.Y.Round(0, this.size.Height - 1)))
                 let movedParticle = new Particle(movedPosition)
                 group movedParticle by movedParticle.Position
                ).ToArray();
            //移動後の粒子たちの位置と，観測情報から累積存在確率分布を生成
            var probabilitySums = new List<ProbabilityCell>(movedParticleGroup.Length);
            var probabilitySum = 0.0;
            foreach (var movedGroup in movedParticleGroup)
            {
                var position = movedGroup.Key;
                var count = movedGroup.Count();
                var probability = observation.ProbabilityAt(position) * count;
                probabilitySum += probability;
                var cell = new ProbabilityCell(position, probabilitySum);
                probabilitySums.Add(cell);
            }
            //計算された存在確率分布をもとに，粒子を再びサンプリングする(リサンプリング)．
            var random = new Random();
            var newParticles = new List<Particle>(this.particles.Count);
            foreach (var _ in Enumerable.Range(0, this.particles.Count).AsParallel())
            {
                var r = random.NextDouble() * probabilitySum;
                var matchedCell = probabilitySums.First(cell => cell.ProbabilitySum > r);
                var newParticle = new Particle(matchedCell.Position);
                newParticles.Add(newParticle);
            }
            //リサンプリングされた粒子を格納
            this.particles = newParticles;
        }

        public void DrawEstimation(Bitmap canvas)
        {
            var particleGroup = this.particles
                .GroupBy(p => p.Position);
            foreach (var group in particleGroup)
            {
                var position = group.Key;
                var count = group.Count();
                var ratio = (double)count / this.particles.Count;
                var color = ColorCircle.At(ratio);
                canvas.SetPixel(position.X, position.Y, color);
            }
        }
    }
}
