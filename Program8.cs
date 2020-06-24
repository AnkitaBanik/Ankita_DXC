using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program8
    {
        static void Main()
        {
            Console.WriteLine("Enter The Number");
             int n= Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for(int i=1;i<=n;i++)
            {
                fact = fact * i;

            }
            Console.WriteLine("Factorial of" + n + "is" + fact);
            Console.ReadKey();
        }
    }
}
