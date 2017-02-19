using System;

namespace ByteProtectTest1
{
    public class Primes
    {
        // check _number is prime number or not
        protected static Boolean IsPrime(UInt64 _number)
        {
            for (UInt64 i = 2; i <= Math.Sqrt(_number); ++i) // 2 is a first prime
            {
                if (_number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        // search next number following by _firstPrime
        protected static UInt64 NextPrime(UInt64 _firstPrime)
        {
            for (UInt64 i = _firstPrime + 1; i <= UInt64.MaxValue; ++i)
            {
                if (IsPrime(i))
                {
                    return i;
                }
            }
            return 1;
        }

        // search next number previous for _firstPrime
        protected static UInt64 PreviousPrime(UInt64 _firstPrime)
        {
            for (UInt64 i = _firstPrime - 1; i >= 2; --i) // 2 is a first prime
            {
                if (IsPrime(i))
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
