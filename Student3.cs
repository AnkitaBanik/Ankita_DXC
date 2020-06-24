using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    class Student3
    {
        public int rollno;
        public string sName;
        public static string Class;
        public static int sem;
        public static string branch;
        public void Details()
        {
            Console.WriteLine("RollNo: " + rollno);
            Console.WriteLine("Sname: " + sName);
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Sem: " + sem);
            Console.WriteLine("Branch: " + branch);
        }

        int[] marks = new int[5] { 65, 75, 80, 90, 99 };
        public void displayresult()
        {

            for (int i = 0; i < marks.Length; i++)
            {
                if (marks[i] < 35)
                {
                    Console.WriteLine("You are fail");
                    break;
                }
                else if (marks[i] > 35 && marks[i] < 50)
                {
                    Console.WriteLine("you are fail");
                }
                else if (marks[i] > 50)
                {
                    Console.WriteLine("you are pass");
                }

            }
        }

    }

    class Student_Details
    {
        static void Main()
        {
            Student3 obj = new Student3();
            obj.rollno = 8;
            obj.sName = "Aroshi";
            obj.Class = "tenth";
            obj.sem = "4";
            obj.branch = "ECE";
            obj.Details();
            obj.displayresult();

            Console.ReadKey();

        }
    }
}
