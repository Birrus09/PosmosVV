namespace PosmosVV.Proc
{
    public static class RandomGen
    {
        public static float RandomNum(ref int seed)
        {
            seed = (seed * 1354 + 7391) % 4273;
            return seed / 4273.0f;
        }

        public static bool Chance(float probability, ref int seed)
        {
            return RandomNum(ref seed) < probability;
        }

        public static int Interval(int min, int max, ref int seed)
        {
            return ((int)(RandomNum(ref seed) * 100000f) % (max - min)) + min;
        }

        public static float IntervalF(float min, float max, ref int seed)
        {
            return (RandomNum(ref seed) * 100000f / 100000.0f) * (max - min) + min;
        }
    }
}