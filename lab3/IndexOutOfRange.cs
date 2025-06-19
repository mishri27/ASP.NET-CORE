using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lab3
{
    class IndexOutOfRange
    {
        public void indexoutofrange()
        {
            int[] num = new int[5];
            Console.WriteLine("Enter 5 element");

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            try
            {
                Console.WriteLine("trying to enter 6th element" + num[5]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Tried to access index outside the array");
                Console.WriteLine(e);
            }
            Console.WriteLine("pragram after exception handling");
        }
    }
}