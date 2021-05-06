using System;

namespace Singleton
{
    class Program
    {   
        static void Main(string[] args)
        {
            Counter counter1 = Counter.GetCounter();
            Counter counter2 = Counter.GetCounter();

            Console.WriteLine("ENTER THE LOOP");
            Console.WriteLine("The current number for third instance is {0}", GetCurrentCounter());
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("{0} LOOP", i);
                Console.WriteLine("The next number for first instance is {0}", counter1.GetNextNumber());
                Console.WriteLine("The next number for second instance is {0}", counter2.GetNextNumber());
            }

            Console.WriteLine("EXIT THE LOOP");
            Console.WriteLine("The current number for third instance is {0}", GetCurrentCounter());
            Console.WriteLine("The sum is {0}", GetSumCounter());
            Console.WriteLine("The starting counter was {0}", (GetCurrentCounter() - GetSumCounter()));
        }

        private static int GetCurrentCounter()
        {
            Counter counter3 = Counter.GetCounter();
            return counter3.GetCurrentNumber();
        }

        private static int GetSumCounter()
        {
            Counter counter4 = Counter.GetCounter();
            return counter4.GetSumNumber();
        }
    }
}
