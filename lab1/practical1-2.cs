﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class practical1_2
    {
        public void printNum()
        {
            Console.WriteLine("Enter First Number : "); 
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number : " + num1);
            Console.WriteLine("Second Number : " + num2);
        }
    }
}
