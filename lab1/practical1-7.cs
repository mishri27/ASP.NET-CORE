using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class practical1_7
    {
        public void display()
        {
            Console.WriteLine("Enter P : "); 
            int p = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter R : ");
            float r = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter N : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Simple Intrest : " + (p * r * n) / 100);
        }
    }
}
