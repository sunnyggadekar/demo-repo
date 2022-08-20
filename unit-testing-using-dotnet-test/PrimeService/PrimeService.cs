using System;

namespace Prime.Services
{
    public class PrimeService
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

        public static String SomeMethodWithOutTest()
        {
            var name = "test";
            var address = "test";
            return $" {name} {address}";
        }

    }
}