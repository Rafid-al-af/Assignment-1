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
            Bank MyBank = new Bank("Developer's bank", 5);
            MyBank.AddAccount(new Account(1, "Rafid", 5000, new Address(4, 10, "Dhaka", "Bangladesh")));
            MyBank.AddAccount(new Account(3003, "Sajib", 5000, new Address(5, 12, "Sylhet", "Bangladesh")));
            MyBank.AddAccount(new Account(1002, "Anik", 3000, new Address(7, 20, "Chittagong", "Bangladesh")));
            MyBank.PrintAllAccounts();
            //ourBank.deletAccount(3001);
        }
    }
}
