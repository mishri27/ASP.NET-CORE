using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Staff
    {
        public String Name; 
        public String Designation;
        public String Department;
        public int Experience;
        public int Salary;

        public Staff(String Name, String Designation, String Department, int Experience, int Salary)
        {
            this.Name = Name;
            this.Designation = Designation;
            this.Department = Department;
            this.Experience = Experience;
            this.Salary = Salary;
        }

        public void displayData()
        {
            if (Designation == "HOD")
            {
                Console.WriteLine("Name : " + Name + " Salary : " + Salary);
            }
        }



    }
}
