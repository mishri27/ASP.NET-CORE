using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Salary
    {
        public double Basic; 
        public double TA;
        public double DA;
        public double HRA;

        public Salary()
        {
            Console.WriteLine("Enter Basic ");
            Basic = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter TA ");
            TA = Convert.ToDouble(Console.ReadLine());
            DA = 10000;
            HRA = 12000;
        }

        public void calculateSalary()
        {
            Console.WriteLine("Gross Salary " + (Basic + TA + HRA + DA));
        }
    }
}
