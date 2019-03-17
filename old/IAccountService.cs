using System;
using System.Threading.Tasks;

namespace BACK
{
    public interface IAccountService
    {
        Task<int> CreateAccountAsync();



    }
}
