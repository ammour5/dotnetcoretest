using System;
using System.Collections.Generic;
using backend.Data.Entities;

namespace backend.Data.Repository
{
    public class BankRepository : IBankRepository
    {
        public BankRepository()
        {
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
