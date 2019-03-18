using System;
namespace backend.Data.Entities
{
    public class BankAccount
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserEmail { get; set; }
        public DateTime CreatedAt { get; set; }
        public double Balance { get; set; }


        public BankAccount()
        {
        }
    }
}
