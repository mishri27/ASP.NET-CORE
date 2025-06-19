using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface Shape
    {
        void Circle();
        void Triangle();
        void Square();
    }
   class AreaCalculate : Shape
    {
        public void Circle()
        {
            Console.Write("Enter radius of circle: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * radius * radius;
            Console.WriteLine(  area);
        }
        public void Triangle()
        {
            Console.Write("Enter base of triangle: ");
            double baseT = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseT * height;
            Console.WriteLine( area);
        }

        public void Square()
        {
            Console.Write("Enter side of square: ");
            double side = Convert.ToDouble(Console.ReadLine());
            double area = side * side;
            Console.WriteLine(area);
        }
    }
}

