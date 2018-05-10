using System.Collections.Generic;
using BLL.Interface.Entities;


namespace DAL.Interface.Interfaces
{
    public interface IRepository
    {
        void AddAccount(Account account);
        void RemoveAccount(Account account);
        IEnumerable<Account> GetAccounts();
    }
}
