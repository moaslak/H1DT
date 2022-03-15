using System;

namespace BankAccount
{
    public class Program
    {
         
     
        public static void Main(string[] args)
        {
            Account account = new Account();
            Menu Menu = new Menu();
            while(true)
                Menu.mainMenu();
        }
    }
}