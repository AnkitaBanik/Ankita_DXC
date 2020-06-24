using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program9
    {
        static void Main()
        {
            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0} {1}", a, b);

            for(int  i=2;i<40;i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
                Console.WriteLine(b + "");
            }
            Console.ReadKey();
            

        }
    }
}
