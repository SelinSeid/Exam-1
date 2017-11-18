using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNumber_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0, br = 0;
            while (n != 0)
            {
                if (n >= 1 && n <= 255)
                {
                    if (n % 2 == 0) { sum = sum + n; br++; }
                    Console.WriteLine("Enter number:");
                    n = int.Parse(Console.ReadLine());

                }
                else
                {
                    Console.WriteLine("Enter number:");
                    n = int.Parse(Console.ReadLine());
                }
            }
            if (br == 0) Console.WriteLine("There aren't even numbers in this diapason [1,255] !!!");
            else
            {
                Console.WriteLine("Finished !!!");
                Console.WriteLine("**********");
                Console.WriteLine();
                Console.WriteLine("Average " + sum / br);
            }
            Console.WriteLine();
        }
    }
}
