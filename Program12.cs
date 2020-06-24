using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program12
    {
        static void Main()
        {
            Console.WriteLine("no divisible by 7 between 100  to 200");
            int no = int.Parse(Console.ReadLine());

            for(int i=100;i<=200;i++)
            {
                if (i % 7 == 0)
                    Console.WriteLine(i + ",");

            }
            Console.ReadKey();

        }
    }
}
