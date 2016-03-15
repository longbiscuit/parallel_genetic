using System;
using System.Security.Cryptography;

namespace nsga2lib
{
    public static class RandomGenerator
    {
        //Optimización: usamos un método lento pero más aleatorio con random criptográfico
        public static bool ResetSeedInEachCall = true;
        public static bool UseCryptoSeed = true;
        public static int Seed = 0;
        private static readonly RNGCryptoServiceProvider rngCrypto = new RNGCryptoServiceProvider();
        private static Random random;

        private static void init()
        {
            if  ( !( random == null || ResetSeedInEachCall )) return;
            if (UseCryptoSeed)
            {
                // http://stackoverflow.com/questions/108819/best-way-to-randomize-a-string-array-in-c
                // http://bytes.com/topic/visual-basic-net/answers/374695-needed-rngcryptoserviceprovider-function-return-integer-within-range
                byte[] seed = new byte[4];
                rngCrypto.GetBytes(seed);
                random = new Random(BitConverter.ToInt32(seed, 0));
            } else
            {
                if (Seed != 0)
                {
                    random = new Random();
                } else
                {
                    random = new Random(Seed);
                }
            }

        }
        public static int Next(int maxValue)
        {
            init();
            lock (random)
            {
                return random.Next(maxValue);
            }
        }
        public static int Next(int minValue, int maxValue)
        {
            init();
            lock (random)
            {
                return random.Next(minValue, maxValue);
            }
        }
        public static double NextDouble()
        {
            init();
            lock (random)
            {
                return random.NextDouble();
            }
        }
    }
}
