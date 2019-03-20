using System;
namespace backend.Data.Entities
{
    public class BankAccountTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BankAccountId { get; set; }
        public decimal Amount { get; set; }
        public TransactionType TransactionType { get; set; }
        public TransactionStatus TransactionStatus { get; set; }

        public BankAccountTransaction(decimal amount, TransactionType transactionType)
        {
            Amount = amount;
            TransactionType = transactionType;
            TransactionStatus = TransactionStatus.PENDING;
        }
    }
}
