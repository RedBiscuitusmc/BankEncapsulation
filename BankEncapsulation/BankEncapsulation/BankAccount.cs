using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        private static double balance = 0;

        public static  double Deposit(double amount)
        {
            return balance += amount;
        }
        public  static double GetBalance()
        {
            return balance;
        }
    }
}
