using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer = "";
            do
            {
                Console.WriteLine("Do you want to calculate some numbers ? (yes or no)");
                answer = Console.ReadLine();
                if (answer == "yes")
                {
                    Console.WriteLine("Enter first numeber: ");
                    double firstNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter second numeber: ");
                    double secondNumber = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter operation:");
                    string operation = Console.ReadLine();
                    if (operation == "+")
                    {
                        double sum = firstNumber + secondNumber;
                        Console.WriteLine("Result is: " + Math.Round(sum + sum * 0.1, 2));
                        break;
                    }
                    if (operation == "-")
                    {
                        if (firstNumber > secondNumber)
                        {
                            Console.WriteLine("Result is: " + Math.Round(Math.Pow(firstNumber, 2) - secondNumber, 2));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Result is: " + Math.Round(Math.Pow(secondNumber, 2) - firstNumber, 2));
                            break;
                        }
                    }
                    if (operation == "*")
                    {
                        Console.WriteLine("Result is: " + Math.Round(firstNumber * Math.Sqrt(secondNumber), 2));
                        break;
                    }
                    if (operation == "/")
                    {
                        if (secondNumber != 0)
                        {
                            Console.WriteLine("Result is: " + Math.Round(firstNumber / secondNumber, 2));
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error!!! You can't divide to 0!!!");
                            break;
                        }

                    }

                }
                else if (answer == "no") Environment.Exit(0);
            }
            while (!(answer == "no"));

        }
    }
}
