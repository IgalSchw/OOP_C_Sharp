using System;

namespace Lesson2_ClassRoles
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount bankAccount1 = new BankAccount();
            bankAccount1.AccountType = AccountType.Personal;
            bankAccount1.Balance = 50000.25;
            
            BankAccount bankAccount2 = new BankAccount(-500.25);
            bankAccount2.AccountType = AccountType.Personal;

            BankAccount bankAccount3 = new BankAccount(2500000.15, AccountType.Business);

            Console.WriteLine("Accounts details:");
            Console.WriteLine(bankAccount1);
            Console.WriteLine(bankAccount2);
            Console.WriteLine(bankAccount3);


            Console.WriteLine("-----------------");

            try
            {
                bankAccount1.DepositToAccount(0.75);
            }
            catch
            {
                Console.WriteLine(bankAccount1.ToString());
            }

            try
            {
                bankAccount2.WithdrawFromAccount(500);
            }
            catch
            {
                Console.WriteLine(bankAccount2.ToString());
            }

            try
            {
                bankAccount3.DepositToAccount(100);
            }
            catch
            {
                Console.WriteLine(bankAccount3.ToString());
            }

            Console.WriteLine("-----------------");
            Console.WriteLine("Accounts details after actions:");
            Console.WriteLine(bankAccount1);
            Console.WriteLine(bankAccount2);
            Console.WriteLine(bankAccount3);

            //BankAccount bankAccountTest = new BankAccount();
            //bankAccountTest.balance = 100.50;
        }
    }

    class TestCase
    {

        
    }


}
