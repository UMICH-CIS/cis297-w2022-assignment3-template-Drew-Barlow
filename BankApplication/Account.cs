using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication
{
    /// <summary>
    /// Base class Account
    /// </summary>
    public abstract class Account
    {
        private decimal AccountBalance;

        public Account(decimal accountBalance)
        {
            Balance = accountBalance;
        }

        /// <summary>
        /// Proterty to initialize the account balance and validate it
        /// </summary>
        public decimal Balance
        {
            get
            {
                return AccountBalance;
            }
            set
            {
                if (value >= 0.0m)
                {
                    AccountBalance = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(AccountBalance)} must be greater than or equal to 0.0. ");
                }
            }
        }
        /// <summary>
        /// Method to add an amount to the balance and validate the amount
        /// </summary>
        /// <param name="amount"></param>
        public virtual void Credit(decimal amount)
        {
            if (amount > 0.0m)
            {
                Balance += amount;
            }
            else
            {
                throw new ArgumentOutOfRangeException(nameof(amount), amount, $"{nameof(Balance)} must be greater than or equal to 0.0. ");
            }
        }

        /// <summary>
        /// Method to subtract an amount from the balance and validate the amount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public virtual bool Debit(decimal amount)
        {
            bool check = true;
            if (Balance - amount >= 0.0m)
            {
                Balance -= amount;
                check = true;
            }
            else
            {
                Console.Write("Debit amount exceeded account balance. ");
                check = false;
            }
            return check;
        }
    }
}
