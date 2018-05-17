using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccountClass
    {
        #region private fields;
        private int id;
        private string name;
        private decimal balance;
        private int bonuspoints;
        private bool closed;
        private string type;
        #endregion
        #region constructors
        public BankAccountClass(int id, string name, decimal balance, int bonuspoints, string type)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
            this.bonuspoints = bonuspoints;
            this.type = type;
        }
        #endregion
        #region Properties
        /// <summary>
        /// Identification number.
        /// </summary>
        public int Id
        {
            get => id;
            set
            {
                id = value;
            }
        }
        /// <summary>
        /// Name(First name and surname) of account client.
        /// </summary>
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }

        }
        /// <summary>
        /// Account balance of client.
        /// </summary>
        public decimal Balance
        {
            get => balance;
            set
            {
                if (balance > 0)
                {
                    balance = value;
                }
                else throw new ArgumentException(nameof(value) + "balance cant be less than 0");
                
            }
        }
        /// <summary>
        /// Bonuspoints of client account.
        /// </summary>
        public int Bonuspoints
        {
             get => bonuspoints;
             set
             {
               if (bonuspoints > 0)
              {
                 bonuspoints = value;
              }
             else throw new ArgumentException(nameof(value) + "bonuspoints cant be less than 0");
        
          }
        }
        /// <summary>
        /// Variable closed responsibles for closing of client account.
        /// </summary>
        public bool Closed
        {
            get => closed;
            set
            {
                closed = value;
            }
        }
        /// <summary>
        /// Type of client account(base,silver,gold,platinum).
        /// </summary>
        public string Type
        {
            get => type;
            set
            {
                type = value;
            }
        }

        #endregion
        #region Methods
        /// <summary>
        /// Closes client account.
        /// </summary>
        public void CloseAccaunt()
        {
            IsAccountClosed();
            Closed = true;
        }
        /// <summary>
        /// Checks is client account closed.
        /// </summary>
        public void IsAccountClosed()
        {
            if (Closed==true) throw new InvalidOperationException("Account is closed");
        }
        /// <summary>
        /// Refilling of client account for a certain amount (sum).
        /// </summary>
        /// <param name="sum"></param>
        public void Refill(decimal sum)
        {
            IsAccountClosed();
            Balance += sum;
        }
        /// <summary>
        /// Withdrawing from the client account for a certain amount(sum)
        /// </summary>
        /// <param name="sum"></param>
        public void Withdrawal(decimal sum)
        {
            IsAccountClosed();
            if (sum < balance) { Balance -= sum; }
            else throw new Exception("Not enough of means");
        }
        /// <summary>
        /// Adds bonus ponts.
        /// </summary>
        /// <param name="bonuspoints"></param>
        /// <param name="type"></param>
        /// <param name="sum"></param>
        public void AddBonuspoints(int bonuspoints, string type,decimal sum)
        {
            IsAccountClosed();
            Bonuspoints += BonuspointsAddQuantity(type,sum);
        }
        /// <summary>
        /// Withdrawls bonus points.
        /// </summary>
        /// <param name="bonuspoints"></param>
        /// <param name="type"></param>
        /// <param name="sum"></param>
        public void Withdrawalbonuspoints(int bonuspoints,string type,decimal sum)
        {
            IsAccountClosed();
            Bonuspoints -= BonuspointsSubtractQuantity(type,sum);
        }
        /// <summary>
        /// Determines how much bonus points will be added depending on the type of account.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int BonuspointsAddQuantity(string type, decimal sum)
        {
            if (type=="Base")
            {
                return (int)(sum/100);
            }
            if (type == "Silver")
            {
                return (int)(sum /50 );
            }
            if (type == "Gold")
            {
                return (int)(sum / 25);
            }
            if (type == "Platinum")
            {
                return (int)(sum / 20);
            }
            else 
            {
                throw new Exception("Enter the correct parameters");
            }
                
        }
        /// <summary>
        /// Determines how much bonus points will be substracted depending on the type of account.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="sum"></param>
        /// <returns></returns>
        public int BonuspointsSubtractQuantity(string type, decimal sum)
        {
            if (type == "Platinum")
            {
                return (int)(sum / 100);
            }
            if (type == "Gold")
            {
                return (int)(sum / 50);
            }
            if (type == "Silver")
            {
                return (int)(sum / 25);
            }
            if (type == "Base")
            {
                return (int)(sum / 20);
            }
            else
            {
                throw new Exception("Enter the correct parameters");
            }

        }
        /// <summary>
        /// Returns quantity of means on the account.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public decimal WhatistheSum(BankAccountClass name)
        {
            IsAccountClosed();
            if (name.balance == 0) { throw new Exception("Are not means on account"); }
            else return name.balance;
        }
        #endregion
    }
}
