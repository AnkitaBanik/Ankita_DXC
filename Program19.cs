using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program19
    {
        static void Main()
        {
            int length = 0;
            string str = "", reverse = "";

            Console.WriteLine("Enter words");
            str = Console.ReadLine();
            length = str.Length - 1;

            while (length >= 0)
            {
                reverse = reverse + str[length];
                length--;
            }
            if (str.Equals(reverse))
                Console.WriteLine("word is palindrome");
            else
                Console.WriteLine("word is not palindrome");
            Console.ReadKey();
        }
    }
}
