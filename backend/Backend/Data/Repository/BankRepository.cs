using System;
using System.Collections.Generic;
using backend.Data.Context;
using backend.Data.Entities;

namespace backend.Data.Repository
{
    public class BankRepository : IBankRepository
    {
        private readonly BankAccountContext _dbContext;

        public BankRepository(BankAccountContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateAccount()
        {
            throw new NotImplementedException();
        }

        public void MakeDeposit(int bankAccountId, double amount)
        {
            throw new NotImplementedException();
        }

        public void MakeWithdrawal(int bankAccountId, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankAccountTransaction> SeeHistory(int bankAccountId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
