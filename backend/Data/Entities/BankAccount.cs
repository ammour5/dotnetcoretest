using System;
namespace backend.Data.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Balance { get; set; }


        public BankAccount()
        {
        }
    }
}
