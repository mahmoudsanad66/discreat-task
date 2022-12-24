using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_number_task
{
    class Program
    {
        static void Main(string[] args)
        {
            float i, j;
            Console.Write("enter number one: ");
            float num1 = int.Parse(Console.ReadLine());
            Console.Write("enter number two: ");
            float num2 = int.Parse(Console.ReadLine());

            for (i = num1; i <= num2; i++)
            {
                float sum = 0;
                for (j = 1; j <= (i / 2); ++j)
                {
                    if (i % j == 0)
                    { sum = sum + j; }
                }
                if (sum == i)
                {
                    Console.WriteLine(sum);
                }
            }
            }
    }
}
