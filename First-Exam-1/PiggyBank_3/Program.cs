using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiggyBank_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
                Random n = new Random();
                double monthSave = 0.0000;
                for (int i = 1; i <= 31; i++)
                {
                    a = n.Next(1, 1000);
                    if ((a >= 1) && (a <= 300)) monthSave = monthSave + (5.1 * Math.Sqrt(a));
                    if ((a >= 301) && (a <= 600)) monthSave = monthSave + (10.098 * Math.Sqrt(a));
                    if ((a >= 601) && (a <= 999)) monthSave = monthSave + (100.00001 * Math.Sqrt(a));
                }
                Console.WriteLine("For a month they will save " + Math.Round(monthSave, 4) + " dollars.");
           
        }
    }
}
