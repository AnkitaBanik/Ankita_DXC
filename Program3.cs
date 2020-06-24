using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program3
    {
        static void Main()
        {
            Console.WriteLine("Enter no");
            int no = Convert.ToInt32(Console.ReadLine());
            {
                if (no % 2 == 0)
                    Console.WriteLine("Even");
                else
                    Console.WriteLine("Odd");
            }
            Console.ReadKey();
        }
    }
}
