using MiNET.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public class Account
    {
        
        private double balance;
        uint accountNumber;

        public double getBalance()
        {
            PrintBalance printBalance = new PrintBalance();
            printBalance.printBalance(balance);
            return this.balance;
        }

        public void withdraw(double withdraw)
        {
            double subWithdraw = this.balance - withdraw;

            if(subWithdraw < 0)
            {
                Console.WriteLine("Not enough money :(");
            }
            else
            {
                this.balance = subWithdraw;
            }
        }

        public void deposit(double deposit)
        {
            this.balance = this.balance + deposit;
        }

        public string writeBalance()
        {
            return this.balance.ToString("C");
        }
    }
}