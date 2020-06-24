using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program5
    {
        static void Main()
        {
            Console.WriteLine("Enter the temperature in fahrenheit");
            int fah = int.Parse(Console.ReadLine());
            Console.WriteLine();

            //Fahrenheit to Celsius Conversion

            int FtoC = (((fah - 32) / 9) * 5);
            Console.WriteLine("The celsius value is {0}:", FtoC);
            Console.ReadLine();
        }

    }
}
