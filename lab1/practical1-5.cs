using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class practical1_5
    {
        public void display()
        {
            Console.WriteLine("Enter Radius : "); 
            int r = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Circle Area : " + (Math.PI * r * r));

            Console.WriteLine("Enter Breath : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Height : ");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Tringle Area : " + (0.5 * h * b));

            Console.WriteLine("Enter Length : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Square Area : " + (l * l)); 
        }
    }
}
