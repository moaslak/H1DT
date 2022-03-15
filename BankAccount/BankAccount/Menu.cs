using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace BankAccount
{
    public class Menu
    {
        Account account = new Account();
        
        public void mainMenu()
        {
            int mode = 0;

            Console.WriteLine("-- Bank Account --");
            Console.WriteLine();

            Console.WriteLine("1 - Get account");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Withdraw");
            Console.WriteLine("4 - Close terminal");
            
            do
            {
                Console.Write(">");
            }while(!(Int32.TryParse(Console.ReadLine(), out mode)));

            switch (mode)
            {
                case 1:
                    account.getBalance();
                    break;
                case 2:
                    uint deposit;
                    do
                    {
                        Console.Write("Enter value to deposit to account: ");
                    } while (!(UInt32.TryParse(Console.ReadLine(), out deposit)));
                    account.deposit(deposit);
                    Console.WriteLine(deposit.ToString("C") + " insereted into account");
                    Console.WriteLine();
                    account.getBalance();
                    break;
                case 3:
                    uint withdraw;
                    do
                    {
                        Console.Write("Enter value to withdraw from account: ");
                    } while (!(UInt32.TryParse(Console.ReadLine(), out withdraw)));
                    Console.WriteLine("Withdrawing " + withdraw.ToString("C") + " from account");
                    account.withdraw(withdraw);
                    
                    Console.WriteLine();
                    account.getBalance();
                    break;
                case 4:
                    Console.WriteLine("Terminal closing");
                    Thread.Sleep(700);
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
    }
}