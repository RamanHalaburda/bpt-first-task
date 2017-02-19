using System;

/*
 * 7901 * 7907 * 7919 = 494725326233
 * 17383 * 17387 * 17389 = 5255620424969
 */
namespace ByteProtectTest1
{
    class Program
    {
        static void Main(string[] args)
        {     
            /*
            UInt64 
                a1 = 105,
                a2 = 106,
                b1 = 494725326233,
                b2 = 494725326233 - 1,
                c1 = 5255620424969,
                c2 = 5255620424969 - 1;*/
            
            CheckPrimeOne cp1 = new CheckPrimeOne();
            cp1.check();
            Console.WriteLine();
            
            CheckPrimeTwo cp2 = new CheckPrimeTwo();
            cp2.check();
            Console.WriteLine();            
            
            CheckPrimeThree cp3 = new CheckPrimeThree();
            cp3.check();
            Console.WriteLine();
            
        }        
    }
}
