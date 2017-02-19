using System;

/*
 * method with external functions
 * check division of number by three primes top down
 * similar to the method CheckPrimeThree.cs, but modified
 */

namespace ByteProtectTest1
{
    public class CheckPrimeTwo : Primes
    {
        public void check()
        {
            bool flag = false; // flag to check the success of the search
            UInt64 number = 0, copyNumber = 0; // user nubmber and copy
            UInt64 prime = 2; // first prime
            UInt16 counter = 0; // counter of founded primes

            // safety input
            do
            {
                Console.WriteLine("Добро пожаловать! Программа проверяет, является ли введённое число произведением трех последовательных простых чисел");
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("Пожалуйста, введите натуральное число (от {0} до {1}):", UInt64.MinValue, UInt64.MaxValue);

                if (UInt64.TryParse(Console.ReadLine(), out number))
                {
                    flag = true;
                    copyNumber = number;
                }
                else
                {
                    Console.Clear();
                }
            }
            while (!flag);

            Console.Write("Да, ");
            prime = NextPrime((UInt64)Math.Pow(number, 1 / 3f) + 1);
            while (prime > (Math.Pow(copyNumber, 1 / 3f) - 10))
            {
                if (prime == 1) 
                {
                    break;
                }
                if (number % prime == 0)
                {
                    if (counter > 2) // == 3 or more, then all primes are founded
                    {
                        break;
                    }
                    Console.Write("{0}", prime);
                    number = number / prime;
                    if (number > 1)
                    {
                        Console.Write(" * ");
                        counter++;
                    }
                }
                prime = PreviousPrime(prime);
            }

            if (counter == 2)
            {
                Console.WriteLine(" = {0}.", copyNumber);
            }
            else
            {
                // clear console line and print "No"
                Console.SetCursorPosition(0, Console.CursorTop);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.WriteLine("Нет.");
            }
        }
    }
}
