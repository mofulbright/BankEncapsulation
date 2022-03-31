using System;
using System.Collections.Generic;
using System.Text;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount()
        {

        }
        private static double _balance = 0;

        public static void Deposit(double initDeposit)
        {
            //_balance = init;
            _balance += initDeposit;
        }
        public static double GetBalance()
        {
            return _balance;
        }
    }
}
