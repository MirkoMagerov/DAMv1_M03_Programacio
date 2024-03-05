using System;

namespace Figuras
{
    public class MirkoMath
    {
        private static MirkoMath math;

        private Random rnd = new Random();

        public int NextIncluded(int num) => rnd.Next(num + 1);

        public static bool IsOdd(int num) => num % 2 != 0;
    }
}
