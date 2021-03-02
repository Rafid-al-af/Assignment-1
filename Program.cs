using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Managment_System
{
    class Program
    {
        static void Main(string[] args)
        {
            Address address1 = new Address(4,10,"Dhaka","Bangladesh");
            Account account1 = new Account(1001, "Rafid", 2000, address1);
            account1.PrintAccount();

            account1.Withdraw(600);
            account1.Deposit(800);
            

            Account account2 = new Account(1002,"Anik",3000,new Address(7,20,"Chittagong","Bangladesh"));
            account2.PrintAccount();

            account1.Withdraw(500);
            account1.Deposit(700);

            Bank MyBank = new Bank();
            MyBank.PrintAllAccounts();






        }
    }
}
