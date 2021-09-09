using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collatz conjecture - Type any positive intiger.");
            string intAsString = Console.ReadLine();
            int number = int.Parse(intAsString);
            CollatzConjecture(number);
        }
        static void CollatzConjecture(int n, int steps = 0)
        {
            if(n == 1)
            {
                Console.WriteLine($"It took {steps} steps to reach 1");
            }
            if(n % 2 == 0)
            {
                int nDivided = n / 2;
                int step = steps + 1;
                Console.WriteLine(nDivided);
                CollatzConjecture(nDivided, step);
            }
            else if(n != 1)
            {
                int threeNplusOne = (n * 3) + 1;
                int step = steps + 1;
                Console.WriteLine(threeNplusOne);
                CollatzConjecture(threeNplusOne, step);
            }
        }
    }
}
