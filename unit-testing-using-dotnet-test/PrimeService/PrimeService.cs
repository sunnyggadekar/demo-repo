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

        public static String SomeMethodWithOutTest(string name, string address)
        {
            var combined = name + address;
            return combined;
        }

        public static String AnotherMethodWithDuplicateCode(string name, string address)
        {
            var combined = name + address;
            return combined;
        }

    }
}