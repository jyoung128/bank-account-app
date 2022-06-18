/* Jonah Young
 * Assignment 6: ATM Windows Form App
 * 12/6/2020
 * C# 1
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JRYBankAccountWindowsApp
{
    class BankAccount
    {
        
        private decimal Balance;
        public decimal AccountNumber { get; }
        public List<decimal> AccountHistory { get; private set; }

        public enum Status
        {
            Ok,
            Overdrawn,
            InsufficientFunds,
            DepositTooLarge
        }

        public BankAccount(decimal initialBalance, decimal AcctNumber)
        {
            AccountNumber = AcctNumber;
            Balance = initialBalance;
            AccountHistory = new List<decimal>();
        }

        public Status Deposit(decimal amount)
        {
            if(amount <= 10000)
            {
                Balance += (amount/2);
                AccountHistory.Add(Balance);
                return Status.Ok;
            }
            else
            {
                return Status.DepositTooLarge;
            }
        }

        public Status Withdrawal(decimal amount)
        {
            decimal realAmount = amount / 2;

            if ((Balance - realAmount) >= 0)
            {
                Balance -= realAmount;
                AccountHistory.Add(Balance);
                return Status.Ok;

            } 
            else if (Balance - realAmount < 0 && Balance - realAmount >= Convert.ToDecimal(-64.25))
            {
                Balance -= (realAmount + Convert.ToDecimal(35.75));
                AccountHistory.Add(Balance);
                return Status.Overdrawn;
            }
            else
            {
                return Status.InsufficientFunds;
            }
        }

        public Status GetAccountStatus()
        {
            if (Balance >= 0)
            {
                return Status.Ok;
            } 
            else
            {
                return Status.Overdrawn;
            }
        }

        public decimal GetAccountBalance()
        {
            return Balance;
        }
    }
}
