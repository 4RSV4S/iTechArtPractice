using System;
using System.Collections.Generic;

namespace Pract11.Utilities
{
    public class Account
    {
        public double balance;
        public int id;
        public List<string> TransferLog = new();
        public bool isInitialized;

        public Account()
        {
            isInitialized = false;
        }
        public Account(double balance, int id)
        {
            this.balance = balance;
            this.id = id;
            isInitialized = true;
        }
        public double GetBalance()
        {
            return balance;
        }
        public int GetAccountId()
        {
            return id;
        }
        public void Add(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            balance += amount;
        }
        public void Withdraw(double amount)
        {
            if (amount > balance)
            {
                throw new ArgumentOutOfRangeException();
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            balance -= amount;
        }
        public void TransferFundsTo(Account anotherAccount, double amount)
        {
            if (anotherAccount is null)
            {
                throw new ArgumentNullException();
            }

            Withdraw(amount);
            anotherAccount.Add(amount);
            ToLogTransfer(anotherAccount, amount);
        }

        public void ToLogTransfer(Account anotherAccount, double amount)
        {
            TransferLog.Add($"{amount} transferred to account {anotherAccount.id}");
        }
    }
}
