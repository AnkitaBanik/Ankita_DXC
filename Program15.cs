using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program15
    {
      static void Main()
        {
            Console.WriteLine("Enter first number");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first nmber");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number");
            int n3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter first number");
            int n4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter first number");
            int n5 = int.Parse(Console.ReadLine());

            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
            {
                Console.WriteLine(n1 + "is smallest number");
            }
            else if (n2 < n3 && n2 < n4 && n2< n5 )
            {
                Console.WriteLine(n2 + "is smallest number");
        }
            else if (n3< n4 && n3< n5)
            {
                Console.WriteLine(n3 + "is smallest number");
            }
            else if (n4 < n5)
            {
                Console.WriteLine(n4+ "is smallest number");
            }
            Console.ReadKey();
            }




        }

    }



