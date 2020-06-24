using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program13
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter first number:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number:");
            c = int.Parse(Console.ReadLine());

            if(a>b && a>c)
            {
                Console.WriteLine("a is greatest");
            }

            else if (b > a && b > c)
            {
                Console.WriteLine("b is greatest");
            }

            else if (c > a && c> b)
            {
                Console.WriteLine("c is greatest");
            }
            else
            {
                Console.WriteLine("invalid");
            }
            Console.ReadKey();
        }

    }
}
