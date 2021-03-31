using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec = 0;
            Console.WriteLine("Enter number of days");

            while (sec == 0)
            {
                if (Int32.TryParse(Console.ReadLine(), out int n) && n > 0)
                {
                    sec = n * 24 * 3600;
                    Console.WriteLine($"There are {sec} seconds in a {n} days");
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong for n, please enter again");
                }
            }
        }
    }
}
