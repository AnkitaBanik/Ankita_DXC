using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment24;

namespace Assignment24
{
    class Student8
    {
        private int rollno;
        private string studName;
        private int MarksInEng;
        private int MarksInMaths;
        private int MarksInScience;
        public double marks;
        public double percentage;
    }

        public void Details(int no, string name, double marksEng, double marksMath, double marksSc)

        {

            Console.WriteLine("rollno:" + rollno);
            Console.WriteLine("studName:" + studName);
            Console.WriteLine("MarksInEng" + MarksInEng);
            Console.WriteLine("MarksInMaths:" + MarksInMaths);
            Console.WriteLine("MarksInScience:" + MarksInScience );
           
        }

        public static void TotalMarks(double d1 , double d2,double d3);
        {
            double totalmarks = d1 + d2 + d3;
            
        }
        public static double Percentage(double d1, double d2, double d3)
        {
            double percentage = (d1 + d2 + d3) / 3;
            return percentage;
        }


    }

    class Calculate
    {
        static void Main()
        {
        Student8 s = new Student8();
            s.Details(101, "Ankita", 65,85,99);
            Console.WriteLine("Total marks is " + Student8.TotalMarks(65, 85, 99));
            Console.WriteLine("Percentage is " + Student8.percentage(65, 85, 99));

            Console.ReadKey();
        }
    }

