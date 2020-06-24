using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program2
    {
        static void Main()

        {
            Console.WriteLine("Enter first number:");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            int n2 = int.Parse(Console.ReadLine());

            int i = n1 + 1;
            while(i<n2)
            {
                Console.WriteLine(i);
                i++;
            }
            Console.ReadKey();
        }
    }
}
