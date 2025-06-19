using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    interface calculate
    {
        void Addition(int a, int b);
        void Substraction(int a,int b); 
    }
    class Result: Calculate
    {
        public void Addition(int a, int b)
        { 
            int sum=a+b;
            Console.WriteLine(sum); 
        }
        public void Substraction(int a, int b)
        {
            int sub = a - b;
            Console.WriteLine(sub);
        }

    }


}
