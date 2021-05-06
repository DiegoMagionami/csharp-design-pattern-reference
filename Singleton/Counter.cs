using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public sealed class Counter
    {
        private static readonly Counter _instance = new Counter();

        public Random random = new Random();
        private int mainCounter = 0;
        private int sumCounter = 0;
        
        private Counter()
        {
            mainCounter = random.Next(10);
        }

        public static Counter GetCounter()
        {
            return _instance;
        }

        public int GetNextNumber()
        {
            sumCounter += 1;
            return mainCounter += 1;
        }

        public int GetCurrentNumber()
        {
            return mainCounter;
        }

        public int GetSumNumber()
        {
            return sumCounter;
        }
    }
}
