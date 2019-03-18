using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using backend.Data.Entities;

namespace backend.Data.Repository
{
    public interface IBankRepository
    {
        Task<BankAccount> CreateAccount();
        Task<double> MakeDeposit(int bankAccountId, double amount);
        Task<double> MakeWithdrawal(int bankAccountId, double amount);
        IEnumerable<BankAccountTransaction> SeeHistory(int bankAccountId, DateTime from, DateTime to);
    }
}
