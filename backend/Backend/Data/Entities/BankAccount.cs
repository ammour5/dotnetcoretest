using System;
namespace backend.Data.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }

        public int CustomerID { get; set; }

        public DateTime CreatedAt { get; private set; }

        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }

        public BankAccount(int customerId, decimal initialDeposit = 0)
        {
            CustomerID = customerId;
            Balance = initialDeposit;
        }
    }
}
