using System;

/*
 * My preferred method.
 * Method with external functions and check division of number by three primes top down.
 * Only 1-2 iteration of the loop
 * And loop includes 4 conditional operators, not all of which is checks for one iteration.
 */

namespace ByteProtectTest1
{
    public class CheckPrimeOne : Primes
    {
        public void check()
        {
            UInt64 number = 0; // input number
            /*
            UInt64 counter = 0; // for debug
             *  comment line 59, 76 and uncomment lines 42, 58, 75
             */
            Boolean flag = false; // flag to check the success of the search            
            
            // safety input
            do
            {
                Console.WriteLine("Добро пожаловать! Программа проверяет, является ли введённое число произведением трех последовательных простых чисел");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Пожалуйста, введите натуральное число (от {0} до {1}):", UInt64.MinValue, UInt64.MaxValue);

                if (UInt64.TryParse(Console.ReadLine(), out number))
                    flag = true;
                else
                    Console.Clear();
            }
            while (!flag);
                        
            // check the number for being the multiplication of three sequence prime numbers
            UInt64 prime = (UInt64)Math.Pow(number, 1 / 3f), nextPrime = 0, nextNextPrime = 0; // the first prime and two next primes
            flag = false;
            do
            {
                // counter++;
                prime = PreviousPrime(prime);
                if (prime == 1)
                {
                    break;
                }
                if (number % prime == 0) // check first prime
                {
                    UInt64 temp = number / prime;
                    nextPrime = NextPrime(prime);
                    if (temp % nextPrime == 0) // check second prime
                    {
                        temp /= nextPrime;
                        nextNextPrime = NextPrime(nextPrime);
                        if (temp % nextNextPrime == 0 && temp / nextNextPrime == 1) // check third prime
                        {
                            // Console.WriteLine("Да, {0} * {1} * {2} = {3}. c = {4}", prime, nextPrime, nextNextPrime, number, counter);
                            Console.WriteLine("Да, {0} * {1} * {2} = {3}.", prime, nextPrime, nextNextPrime, number);
                            flag = true;
                            break;
                        }
                    }
                }
            }
            while (prime > (Math.Pow(number, 1 / 3f) - 10));
            /* because:
             * (prime) * (~prime) * (~prime) ~= number
             *  then prime < number ^ (1/3)
             */

            // check succcess
            if (!flag)
            {
                // Console.WriteLine("Нет. c = {0}", counter);
                Console.WriteLine("Нет.");
            }
        }
    }
}
