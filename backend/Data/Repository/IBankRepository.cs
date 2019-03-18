using System;
using System.Collections.Generic;
using backend.Data.Entities;

namespace backend.Data.Repository
{
    public interface IBankRepository
    {
        void CreateAccount();
        void MakeDeposit(int bankAccountId, double amount);
        void MakeWithdrawal(int bankAccountId, double amount);
        IEnumerable<BankAccountTransaction> SeeHistory(int bankAccountId, DateTime from, DateTime to);
    }
}
