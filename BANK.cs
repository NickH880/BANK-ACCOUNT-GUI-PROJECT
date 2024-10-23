using System;
using System.Collections.Generic;

namespace BANK_PROJECT
{
    public class BANK //Bank
    {
        private List<TRANSACTION> transactions; //Store transactions
        private const int MaxTransactions = 100; //Maximum transactions from rubric
        public decimal Balance { get; private set; } // Account balance

        public BANK() 
        {
            transactions = new List<TRANSACTION>(); //Initialize list
            Balance = 0; //Start with no balance
        }

        public void Deposit(decimal amount) //Deposit money
        {
            Balance += amount; //Increase balance
            AddTransaction(new TRANSACTION("Deposit", amount)); //Add transaction
        }

        public void Withdraw(decimal amount) //Withdraw money
        {
            if (amount <= Balance) //Check balance
            {
                Balance -= amount; //Decrease balance
                AddTransaction(new TRANSACTION("Withdraw", amount)); //Add transaction
            }
            else
            {
                throw new InvalidOperationException("Insufficient funds"); //For insufficient funds
            }
        }

        private void AddTransaction(TRANSACTION transaction) //Add transaction to the list
        {
            if (transactions.Count >= MaxTransactions) //Check max reached
            {
                transactions.RemoveAt(0); //Remove transaction
            }
            transactions.Add(transaction); //Add new transaction
        }

        public List<TRANSACTION> GetTransactions() //Get history
        {
            return transactions; //Return transactions
        }
    }
}
