using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program18
    {
        static void Main()
        {
            Console.WriteLine("enter words");
            string str1 = Console.ReadLine();
            string str2= Console.ReadLine();
            bool flag = false;

            if (str1.Equals(str2))
            {
                flag = true;
            }
            if(flag)
                Console.WriteLine("same words");
            else
                Console.WriteLine("not same words");
            Console.ReadKey();

        }
    }
}
