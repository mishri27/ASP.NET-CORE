using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    internal class Bank_Account
    {
        public int AccountNumber; 
        public String UserName;
        public String Email;
        public String Type;
        public double Balance;


        public void getAccountDetails()
        {
            Console.WriteLine("Enter AccountNumber : ");
            AccountNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter UserName : ");
            UserName = (Console.ReadLine());
            Console.WriteLine("Enter Email : ");
            Email = Console.ReadLine();
            Console.WriteLine("Enter Type : ");
            Type = (Console.ReadLine());
            Console.WriteLine("Enter Balance : ");
            Balance = Convert.ToDouble(Console.ReadLine());

        }
        public void displayAccountDetails()
        {
            Console.WriteLine("AccountNumber : " + AccountNumber);
            Console.WriteLine("UserName : " + UserName);
            Console.WriteLine("Email : " + Email);
            Console.WriteLine("Type : " + Type);
            Console.WriteLine("Balance : " + Balance);
        }
    }
}

