using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your FirstName");
            string fname = Console.ReadLine();
            Console.WriteLine("Enter your LastName");
            string lname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int s = 0;

            while (s == 0)
            {
                if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
                {
                    Console.WriteLine($"FirstName-{fname}\nLastName-{lname}\nAge-{age}");
                    s = 1;
                }
                else
                {
                    Console.WriteLine("Entered expression is wrong for age, please enter again");
                }
            }

        }
    }
}
