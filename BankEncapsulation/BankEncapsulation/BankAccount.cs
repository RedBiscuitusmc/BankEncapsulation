using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public static double balance = 0;

        public void Deposit(double amount)
        {
            balance += amount;
        }
        public static double GetBalance()
        {
            return balance;
        }
    }
}
