using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    abstract class sum()
    {
        public abstract void SumOfTwo(int a, int b);
        public abstract void SumOfThree(int a, int b, int c);
    }
     class Calculate : sum
    {
        public override void SumOfTwo(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Sum of two numbers: " + result);
        }

    public override void SumOfThree(int a, int b, int c)
        {
            int result = a + b + c;
            Console.WriteLine("Sum of three numbers: " + result);
        }
    }
}
