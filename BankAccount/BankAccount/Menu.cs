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
                    double deposit;
                    do
                    {
                        Console.Write("Enter value to deposit to account: ");
                    } while (!(double.TryParse(Console.ReadLine(), out deposit)));
                    account.deposit(deposit);
                    Console.WriteLine(deposit.ToString("C") + " insereted into account");
                    Console.WriteLine();
                    account.getBalance();
                    break;
                case 3:
                    double withdraw = 0;
                    do
                    {
                        if(withdraw < 0)
                        {
                            Console.WriteLine("You cannot withdraw a negative number");
                        }
                        do
                        {
                            Console.Write("Enter value to withdraw from account: ");
                        } while (!(double.TryParse(Console.ReadLine(), out withdraw)));
                    } while (withdraw < 0);
                     
                        
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