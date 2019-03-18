using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public Task<BankAccount> CreateAccount()
        {
            throw new NotImplementedException();
        }

        public Task<double> MakeDeposit(int bankAccountId, double amount)
        {
            throw new NotImplementedException();
        }

        public Task<double> MakeWithdrawal(int bankAccountId, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BankAccountTransaction> SeeHistory(int bankAccountId, DateTime from, DateTime to)
        {
            throw new NotImplementedException();
        }
    }
}
