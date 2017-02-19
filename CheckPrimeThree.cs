using System;

/*
 * method without external functions
 * check division of number by three primes down up
 */

namespace ByteProtectTest1
{
    public class CheckPrimeThree 
    {
        public void check()
        {
            bool flag = false;
            UInt64 number, copyNumber = 0;
            UInt64 i = 2;
            UInt16 counter = 0;

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
            while (i <= number)
            {
                if (number % i == 0)
                {
                    if (counter > 2)
                    {
                        break;
                    }
                    Console.Write("{0}", i);
                    number = number / i;
                    if (number > 1)
                    {
                        Console.Write(" * ");
                        counter++;
                    }
                }
                else
                {
                    i = i + 1;
                }
            }
            if (counter == 2)
            {
                Console.WriteLine(" = {0}.", copyNumber); // print result
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