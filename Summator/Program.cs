using System;

namespace Summator
{
    public class Program
    {
        static void Main(string[] args)
        {
            long sum = Summator.Sum(new long[] { 1, 2, 3, 4, 5, 6 });

            if (sum == 21)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

            long average = Summator.Average(new long[] { 5, 10, 15 });

            if (average == 10)
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }

        }
    }
}
