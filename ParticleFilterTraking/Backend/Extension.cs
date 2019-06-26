using System;

namespace ParticleFilterTraking.Backend
{
    static class Extension
    {
        public static TResult Let<TInput, TResult>(this TInput input, Func<TInput, TResult> func) => func(input);
        public static T Round<T>(this T value, T min, T max) where T : IComparable<T>
        {
            if (value.CompareTo(min) < 0) return min;
            if (value.CompareTo(max) > 0) return max;
            return value;
        }
    }
}
