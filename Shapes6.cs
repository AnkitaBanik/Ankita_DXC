using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    class Shapes6
    {
        public void CalculateArea(float x)
        {
            Console.WriteLine("Area of Square is " + x * x + " sq units");
        }
        public void CalculateArea(double r)
        {
            double area = 3.14 * r * r;
            Console.WriteLine("Area of Circle is " + area + " sq units");
        }

        public void CalculateArea(double x, double y)
        {
            Console.WriteLine("Area of Reactangle is " + x * y + " sq units");
        }

        public void CalculateArea(float height, float Base)
        {
            Console.WriteLine("Area of Traiangle is " + (height * Base) / 2 + " sq units");
        }

    }
    class Test_Area
    {
        static void Main()
        {
            Shapes6 obj = new Shapes6();
            obj.CalculateArea(2.5f);
            obj.CalculateArea(20, 10);
            obj.CalculateArea(24, 80);
            obj.CalculateArea(1.8, 8.7);
            Console.ReadKey();
        }
        }
    }
