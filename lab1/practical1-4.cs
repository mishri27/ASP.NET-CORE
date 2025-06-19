using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class practical1_4
    {
        public void display()
        {
            Console.Write("Enter Length : ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter  Width : ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Area : " + (l * b));
        }
    }
}
