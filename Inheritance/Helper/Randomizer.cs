using System;

namespace Inheritance.Helper
{
    internal class Randomizer
    {
        private static readonly Random Rnd;

        static Randomizer()
        {
            Rnd = new Random();
        }

        public static int GetRandom(int min, int max)
        {
            return Rnd.Next(min, max);
        }
    }
}
