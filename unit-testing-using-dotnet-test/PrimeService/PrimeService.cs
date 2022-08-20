using System;

namespace Prime.Services
{
    public class PrimeService
    {
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }

        public static void EmptyMethod1()
        {

        }

        public async void EmptyMethod2()
        {

        }


    }
}