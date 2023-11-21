using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment17Part1day12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankaccount = new BankAccount();
            bankaccount.Deposit();
            bankaccount.Withdraw();
            bankaccount.Details();
        }
    }
}
