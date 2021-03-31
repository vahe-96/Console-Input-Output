using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = 0;
            Console.WriteLine("Enter radius of circle");
            double pi = Math.PI;

            while (length == 0)
            {
                if (Double.TryParse(Console.ReadLine(), out double r) && r > 0)
                {
                    length = 2 * r;
                    Console.WriteLine($"The length of circle with radius {r} is {length}*pi");
                    Console.WriteLine($"Where pi={pi}");
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong for radius, please enter again");
                }
            }
        }
    }
}
