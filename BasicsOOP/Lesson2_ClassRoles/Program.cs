using System;
using System.Collections.Generic;

namespace Lesson2_ClassRoles
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Bank account
            double depositSum = 0;
            double WithdrawSum = 0;

            BankAccount[] bankAccounts = new BankAccount[3];

            // first account
            bankAccounts[0] = new BankAccount();
            bankAccounts[0].AccountType = AccountType.Personal;
            bankAccounts[0].Balance = 50000.25;

           
            // second account
            bankAccounts[1] = new BankAccount(-500.25);
            bankAccounts[1].AccountType = AccountType.Personal;

            // third account
            bankAccounts[2] = new BankAccount(2500000.15, AccountType.Business);

            Console.WriteLine("Initialized Accounts details:");
            printAccounts(bankAccounts);

            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                Console.WriteLine("Trying deposit...");
                depositSum = 1.75;
                bankAccounts[0].DepositToAccount(depositSum);
                Console.WriteLine("The operation was performed successfully!");
            }
            catch
            {
                Console.WriteLine("Wrong deposit sum: " + depositSum);
                Console.WriteLine(bankAccounts[0].ToString());
            }
            depositSum = 0;
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                Console.WriteLine("Trying withdraw...");
                WithdrawSum = 500;
                bankAccounts[1].WithdrawFromAccount(WithdrawSum);
                Console.WriteLine("The operation was performed successfully!");
            }
            catch
            {
                Console.WriteLine("Withdraw sum: " + WithdrawSum);
                Console.WriteLine("Bank account frame: " + bankAccounts[1].accountFrame);
                Console.WriteLine(bankAccounts[1].ToString());
            }
            WithdrawSum = 0;
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                Console.WriteLine("Trying deposit...");
                depositSum = 100;
                bankAccounts[2].DepositToAccount(depositSum);
                Console.WriteLine("The operation was performed successfully!");
            }
            catch
            {
                Console.WriteLine("Wrong deposit sum: " + depositSum);
                Console.WriteLine(bankAccounts[2].ToString());
            }
            depositSum = 0;
            Console.WriteLine();
            Console.WriteLine();


            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Account status after performing operations:");
            printAccounts(bankAccounts);

            // test
            //BankAccount bankAccountTest = new BankAccount();
            //bankAccountTest.balance = 100.50;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            // Static procedure
            try
            {
                WithdrawSum = 400;
                Console.WriteLine("Trying transfer money...");
                bankAccounts[0].TransferMoneyFromAnotherAccount(bankAccounts[1], WithdrawSum);  // static transfer from bank_account2 to bank_account1
                Console.WriteLine("The operation was performed successfully!");
            }
            catch
            { 
                Console.WriteLine("Wrong WithdrawSum sum: " + WithdrawSum);
                Console.WriteLine("Bank account frame: " + bankAccounts[1].accountFrame);
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Account status after performing operations:");
            printAccounts(bankAccounts);

            //2. Print reverse string
            Console.WriteLine("------------------------------------------------------------------");
            Console.WriteLine("Reverse string:");
            Console.WriteLine(StringHelper.ReverseString("Hello World"));

            //3. Text file
            List<string> list = FileHelper.ReadFile(FileHelper.FilePath);

            FileHelper.CreateFile(FileHelper.FilePathEmails, list);
        }

        // print accounts
        public static void printAccounts(BankAccount[] accounts)
        {
            foreach (var item in accounts)
            {
                Console.WriteLine(item.ToString());
            }        
        }    
    }
}
