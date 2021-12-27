using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson2_ClassRoles
{
    
    class BankAccount
    {
        private string accountNumber = "1999";
        private static int counter = 1;
        
        private double balance;
        private AccountType accountType;
        private double accountFrame = -1000;

        public BankAccount()
        {
            GenerateAccountNumber();
        }

        public BankAccount(double pBalance)
        {
            balance = pBalance;
            GenerateAccountNumber();
        }

        public BankAccount(AccountType pAccountType)
        {
            accountType = pAccountType;
            GenerateAccountNumber();
        }

        public BankAccount(double pBalance,AccountType pAccountType)
        {
            balance = pBalance;
            accountType = pAccountType;
            GenerateAccountNumber();
        }

        private void GenerateAccountNumber()
        {
            accountNumber = accountNumber + counter;
            IncrementCounter();
        }

        private static void IncrementCounter()
        {
            counter++;
        }

        // Properties
        public AccountType AccountType
        {
            get => accountType;
            set => accountType = value;
        }

        public double Balance
        {
            get => balance;
            set => balance = value;
        }

        // Without setter
        private string AccountNumber
        {
            get => accountNumber;
            set => accountNumber = value;
        }

        public void WithdrawFromAccount(double amount)
        {
            if (Balance - amount >= accountFrame)
                Balance = Balance - amount;
            else
                throw new BankActionException("Wrong amount! you exceeding the bank account limit");
        }

        public void DepositToAccount(double amount)
        {
            if (amount > 0)
                Balance = Balance + amount;
            else
                throw new BankActionException("Wrong amount! must me positive");
        }


        public override string ToString()
        {
            return "Account Number: " + accountNumber + ", Balance: " + balance + ", AccountType: " + accountType;
        }
    }

    public enum AccountType
    { 
        Personal,
        Business
    }



}
