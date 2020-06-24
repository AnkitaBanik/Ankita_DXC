using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program4
    {
        static void Main()
        {
            Console.WriteLine("Enter  the numbers");
            int total = Convert.ToInt32(Console.ReadLine());

            List<int> numberArray = new List<int>();
            Console.WriteLine("Enter" + total + "Number");
            for (int loopIndex = 0; loopIndex < total; loopIndex++)
            {
                numberArray.Add(Convert.ToInt32(Console.ReadLine()));
            }
            foreach(int result in numberArray)
            {
                if (result % 2 == 0)
                {
                    Console.WriteLine(result + "is An  Even Number");
                }
                else
                {
                    Console.WriteLine(result + "is An Odd Number");
                }
            }
            Console.ReadKey();

        }
    }
}
