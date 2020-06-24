using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program11
    {
       static void Main()
        {
            Console.WriteLine("Enter no");
           int no =Convert.ToInt32(Console.ReadLine());


               no = 0;
               Console.WriteLine("Multplication table");
               for(int i=1;i<=20; i++)
                {
                    Console.WriteLine("{0}*{1}={2}", no, i, (no * i));
                }
            }
        }
    }
