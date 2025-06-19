using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class practical1_9
    {
        public void display()
        {
            Console.WriteLine("Enter Number : "); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("Number 1 : " + num1);
            Console.WriteLine("Number 2 : " + num2);
        }
    }
}
