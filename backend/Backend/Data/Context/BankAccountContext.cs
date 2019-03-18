using System;
using backend.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace backend.Data.Context
{
    public class BankAccountContext : DbContext
    {
        public BankAccountContext()
        {
        }

        public BankAccountContext(DbContextOptions<BankAccountContext> options)
            : base(options)
        {

        }

        public DbSet<BankAccount> BankAccounts { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //if (!optionsBuilder.IsConfigured)
            //{
            //    optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            //}
        }

    }
}
