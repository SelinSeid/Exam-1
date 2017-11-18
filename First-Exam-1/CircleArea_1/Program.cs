using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int height = random.Next(33, 187);
            Console.WriteLine("The triangle random heigh is = " + height);
            Console.WriteLine("The circle area is = " + Math.Round((Math.PI * height * height), 2));
        }
    }
}
