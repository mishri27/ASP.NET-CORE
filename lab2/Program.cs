using System;

namespace lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Candidate c = new Candidate(); 
            //c.getCandidate();
            //c.displayCandidate();



            //Staff s1 = new Staff("mishri", "HOD", "CE", 3, 100000);
            //Staff s2 = new Staff("jinkal", "Admin", "CE", 2, 90000);
            //Staff s3 = new Staff("dharmi", "TA", "CE", 1, 40000);
            //Staff s4 = new Staff("krisha", "Faculty", "ME", 4, 10000);
            //Staff s5 = new Staff("utsav", "Faculty", "CE", 6, 70000);
            //s1.displayData(); 
            //s2.displayData();
            //s3.displayData();
            //s4.displayData();
            //s5.displayData();



            //Bank_Account b = new Bank_Account(); 
            //b.getAccountDetails();
            //b.displayAccountDetails();


            //Student s = new Student();
            //s.getStudentDetails();
            //s.displayStudentDetails();



            //Interest interest = new Interest(); 
            //interest.GetAccountInfo();
            //interest.CalculateInterest();


            //Salary s = new Salary(); 
            //s.calculateSalary();


            //Distance d = new Distance(); 
            //Console.WriteLine("Total Distance : " + d.calculateDistance());



            Table t = new Table("Material", 50000, 120, 1200); 
            t.displayData();

        }
    }
}
