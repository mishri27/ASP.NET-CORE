using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
   class StringMethod
    {
        public void stringmethods()
        {
            string str = " Hello World c# my name is Mishri";
            Console.WriteLine("Original String: '" + str + "'");
            Console.WriteLine("\nLength: " + str.Length);
            Console.WriteLine("Uppercase: " + str.ToUpper());
            Console.WriteLine("Lowercase: " + str.ToLower());
            Console.WriteLine("Trimmed: '" + str.Trim() + "'");
            Console.WriteLine("Substring (6, 5): " + str.Substring(6, 5)); // World
            Console.WriteLine("IndexOf 'C': " + str.IndexOf('C'));
            Console.WriteLine("LastIndexOf 'M': " + str.LastIndexOf('M'));
            Console.WriteLine("Replace 'World' with 'Universe': " + str.Replace("World", "Universe"));
            Console.WriteLine("Contains 'C#': " + str.Contains("C#"));

           
        }
    }
}
    