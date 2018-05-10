using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Interface.Entities;
using BLL.Interface.Interfaces;


namespace BLL.ServiceImplementation
{
    public class AccountService : IAccountService
    {
        #region private fields 
        private const int BaseAccountBonusValue = 10;
        private const int GoldAccountBonusValue = 30;
        private const int PlatinumAccountBonusValue = 50;

        private readonly IAccountGenerateIdNumber _accountGenerateIdNumber;
        private readonly IRepository _accountRepository;
        private readonly IEmailService _gmailService;

        #endregion

        #region ctor
        public AccountService(IRepository accountRepsitory, IAccountGenerateIdNumber accountGenerateIdNumber, IEmailService gmailService)
        {
            _accountRepository = accountRepsitory;
            _accountGenerateIdNumber = accountGenerateIdNumber;
            _gmailService = gmailService;
        }
        #endregion

        #region public
        /// <summary>
        /// Add money to accout's amount and add bonus points
        /// </summary>
        /// <param name="account"> account in which the balance is replenished. </param>
        /// <param name="money"> money that we add</param>
        public void AddMoney(Account account, decimal money)
        {
            if (ReferenceEquals(account, null))
                throw new ArgumentException(nameof(account));
            account.AddMoney(money);
            _accountRepository.UpdateAccount(account);
        }

        public void AddMoney(string accountId, decimal money)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentException(nameof(accountId));
            var account = _accountRepository.GetAccounts().FirstOrDefault(acc => acc.Id == accountId);
            account.ConvertToAccount().AddMoney(money);
            _accountRepository.UpdateAccount(account);
        }

        /// <summary>
        /// Withdraw money from accout's amount and add bonus points
        /// </summary>
        /// <param name="account">account from which we withdraw money.</param>
        /// <param name="money">money that we withdraw</param>
        public void WithdrawMoney(Account account, decimal money)
        {
            if (ReferenceEquals(account, null))
                throw new ArgumentException(nameof(account));
            account.WithdrawMoney(money);
            _accountRepository.UpdateAccount(account);
        }

        public void WithdrawMoney(string accountId, decimal money)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentException(nameof(accountId));
            var account = _accountRepository.GetAccounts().FirstOrDefault(acc => acc.Id == accountId);
            account.ConvertToAccount().DivMoney(money);
            _accountRepository.UpdateAccount(account);
        }


        /// <summary>
        /// Remove account 
        /// </summary>
        /// <param name="account">account that is removing</param>
        public void CloseAccout(Account account)
        {
            if (ReferenceEquals(account, null))
                throw new ArgumentException(nameof(account));
            _accountRepository.RemoveAccount(account);
        }

        public void CloseAccout(string accountId)
        {
            if (string.IsNullOrEmpty(accountId))
                throw new ArgumentException(nameof(accountId));
            var account = _accountRepository.GetAccounts().FirstOrDefault(acc => acc.Id == accountId);
            _accountRepository.RemoveAccount(account);
        }

        public string GetAccount(string accountId)
        {
            if (string.IsNullOrWhiteSpace(accountId))
            {
                throw new ArgumentException(nameof(accountId));
            }

            var accounts = _accountRepository.GetAccounts();
            var account = accounts.FirstOrDefault(acc => acc.Id == accountId);
            if (ReferenceEquals(account, null))
            {
                throw new ArgumentException($"Account with id {accountId} not found");
            }

            return account.ConvertToAccount().ToString();
        }

        /// <summary>
        /// Create new account
        /// </summary>
        /// <param name="accountType">Type of account : Base, Gold, Platinum</param>
        /// <param name="firstName"> owner name</param>
        /// <param name="lastName">owner lastname</param>
        /// <param name="amount"></param>
        /// <returns>new account</returns>
        public Account CreateAccount(AccountType accountType, string firstName, string lastName, decimal amount, string email)
        {
            _accountRepository.AddAccount();
            var account = CreateAccount(TypeOfAccount(accountType), _accountGenerateIdNumber.GenerateId(), firstName,
                lastName, amount, GetBonuses(accountType), email);

            _accountRepository.AddAccount(account);
            return account;
        }

        public Account CreateAccount(AccountType accountType, string firstName, string lastName, decimal amount, string email, IAccountGenerateIdNumber accountGenerateIdNumberNotField)
        {
            var account = CreateAccount(TypeOfAccount(accountType), accountGenerateIdNumberNotField.GenerateId(), firstName,
                lastName, amount, GetBonuses(accountType), email);

            _accountRepository.AddAccount(account);
            return account;
        }
        #endregion

        #region private 
        private Account CreateAccount(Type accountType, string id, string firstName, string lastName, decimal amount,
            int bonusPoints, string email)
        {
            return (Account)Activator.CreateInstance(accountType, id, firstName, lastName, amount, bonusPoints, email);
        }

        private static int GetBonuses(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Base:
                    return BaseAccountBonusValue;
                case AccountType.Gold:
                    return GoldAccountBonusValue;
                case AccountType.Platinum:
                    return PlatinumAccountBonusValue;
                default:
                    throw new ArgumentException(nameof(accountType));
            }
        }

        private static Type TypeOfAccount(AccountType accountType)
        {
            switch (accountType)
            {
                case AccountType.Base:
                    return typeof(BaseAccount);
                case AccountType.Gold:
                    return typeof(GoldAccount);
                case AccountType.Platinum:
                    return typeof(PlatinumAccount);
                default:
                    throw new ArgumentException(nameof(accountType));
            }
        }
        #endregion
    }

}
