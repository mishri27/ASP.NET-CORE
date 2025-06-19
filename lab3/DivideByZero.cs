using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    class DivideByZero
    {
        public void  dividebyzero()
        {
            int b = 0;
            int ans;
            try
            {
                ans = 2 / b;
                Console.WriteLine(ans);
            }
            catch (Exception ex) 
            {
                Console.WriteLine("error: can not divide by zero");
              Console.WriteLine(ex);
            }
            Console.WriteLine("program after exception handling");


        }
        
        
    }
}
