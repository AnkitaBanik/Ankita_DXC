using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    class BankException : Exception
    {
        public BankException(string msg) : base(msg) { }
    }
    class BankAccount7
    {
        public string name;
        public long accountNumber;
        public string accountType;
        public double balance;


        public BankAccount7()
        {
            Console.WriteLine("Enter name of depositor");
            name = Console.ReadLine();
            Console.WriteLine("Enter Account number");
            accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Account type");
            accountType = Console.ReadLine();
            Console.WriteLine("Enter balance");

            balance = double.Parse(Console.ReadLine());
        }

        public void Deposit(double newAmount)
        {
            balance = balance + newAmount;
        }

        public void Withdraw(double amount)
        {
            try
            {
                if (balance - amount < 0)
                    throw new BankException("Not sufficient balance in account");
                else
                    balance = balance - amount;
            }
            catch (BankException b)
            {
                Console.WriteLine(b.Message);
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine(name +  + balance);
        }
    }

    class Test_BankAccount
    {
        static void Main()
        {
            BankAccount7 ba = new BankAccount7();
            ba.Deposit(10000);
            ba.Withdraw(5000);
            ba.DisplayBalance();
            Console.ReadKey();
        }
    }
}
