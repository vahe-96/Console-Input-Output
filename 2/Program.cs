using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 0;
            Console.WriteLine("Enter first number");

            while (p == 0)
            {
                if (Double.TryParse(Console.ReadLine(), out double a) && a > 0)
                {
                    Console.WriteLine("Enter second number");
                    while (p == 0)
                    {
                        if (Double.TryParse(Console.ReadLine(), out double b) && b > a)
                        {
                            p = 100 * a / b;
                            Console.WriteLine($"{a} is {p} percentage of {b}");
                        }
                        else
                        {
                            Console.WriteLine("Entered expression is wrong for second number, please enter again");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong for first number, please enter again");
                }
            }
        }
    }
}
