using System;
namespace backend.Data.Entities
{
    public class BankAccountTransaction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int BankAccountId { get; set; }
        public double Amount { get; set; }

        public BankAccountTransaction()
        {
        }
    }
}
