using System;

namespace the_PRIME
{
    class Program
    {
        static void Main(string[] args)
        {
            int j, i;

            Console.Write("Enter number one: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number two: ");
            int num2 = int.Parse(Console.ReadLine());
            bool prime = true;
            for (i = num1; i <= num2; i++)
            {

                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                        prime = false;

                }
                if (prime == true && i != 1 && i != 0)
                { Console.WriteLine(i); }
                prime = true;
            }
        }
    }
}
