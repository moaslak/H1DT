using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankAccount
{
    public class PrintBalance : Account
    {
        public void printBalance(double balance)
        {
            Console.Write("Currant balance is: " + balance.ToString("C"));
            Console.WriteLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}