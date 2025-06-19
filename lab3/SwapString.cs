using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    internal class SwapString
    {
        public void Swap()
        {
            Console.WriteLine("enter string");
            string input = Console.ReadLine();
            string swap="";
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                    swap += char.ToLower(c); 
                else if (char.IsLower(c))
                    swap += char.ToUpper(c); 
                else
                    swap += c;
            }
            Console.WriteLine(swap);

        }
    }
}
