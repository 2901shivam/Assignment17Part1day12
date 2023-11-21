using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17Part1day12
{
    public class BankAccount
    {
        readonly int AccountNumber;
        string AccountHolderName;
        private double Balance;

        public BankAccount()

        {
            AccountNumber = 111;
            AccountHolderName = "Shivam";
            Balance = 0;
            
        }
        public void Deposit()
        {
            Console.WriteLine("Enter the amount which you want to deposit in your Account");
            double amount = int.Parse(Console.ReadLine());
            Balance += amount;
            Console.WriteLine("Amount in your account after Depositing:\t"+Balance);

        }
        public void Withdraw()
        {
            Console.WriteLine("Enter the amount which you want to withdraw from the account");
            double amount = int.Parse(Console.ReadLine());
            Balance -= amount;
            Console.WriteLine("Amount in your account after Withdraw:\t" + Balance);
        }
        public void Details()
        {
            Console.WriteLine("****Account Details****");
            Console.WriteLine("Account Number:\t"+AccountNumber);
            Console.WriteLine("Account Holdername\t"+AccountHolderName);
            Console.WriteLine("Balance\t" + Balance);
        }
    }
}
