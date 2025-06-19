using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab1
{
    internal class practical1_3
    {
        public void display()
        {
            Console.WriteLine("Enter Name : "); 
            String name = Console.ReadLine();
            Console.WriteLine("Enter Country Name : ");
            String country = Console.ReadLine();
            Console.WriteLine("Hello! " + name + " From Country " + country);
        }
    }
}
