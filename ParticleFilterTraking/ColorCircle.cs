using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace ParticleFilterTraking
{
    static class ColorCircle
    {
        private static readonly IReadOnlyList<Color> colorCircle;
        static ColorCircle()
        {
            var interval = 1.0 / byte.MaxValue;
            var colors = new List<Color>();
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb((byte)(interval * i), 0, 255)));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, 0, 255 - (byte)(interval * i))));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, (byte)(interval * i), 0)));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, 255 - (byte)(interval * i), 0)));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, 0, 0)));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, 0, 0)));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, 0, 0)));
            colors.AddRange(Enumerable.Range(0, byte.MaxValue).Select(i => Color.FromArgb(255, 0, 0)));
            colorCircle = colors;
        }
        public static Color At(double r)
        {
            var index = (int)(r * (colorCircle.Count - 1));
            return colorCircle[index];
        }
    }
}
