using System;

namespace Prime.Services
{
    public static class PrimeService
    {
        public static bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }

        public static string Display(string input)
        {
            return input;
        }

    }
}