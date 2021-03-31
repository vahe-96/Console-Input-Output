using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal area = 0;
            Console.WriteLine("Enter radius of circle");
            double pi = Math.PI;

            while (area == 0)
            {
                if (Decimal.TryParse(Console.ReadLine(), out decimal r) && r > 0)
                {
                    area = r * r;
                    Console.WriteLine($"The Area of circle with radius {r} is {area}*pi");
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
