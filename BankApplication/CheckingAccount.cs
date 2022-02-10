using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication
{
    /// <summary>
    /// Class for the checking account that inherits from base class Account
    /// </summary>
    public class CheckingAccount : Account
    {
        private decimal fee;

        public CheckingAccount(decimal balance, decimal fee) : base(balance)
        {
            Fee = fee;
        }

        /// <summary>
        /// Property that initializes the withdrawl fee and validates it
        /// </summary>
        public decimal Fee
        {
            get
            {
                return fee;
            }
            set
            {
                if (value > 0)
                {
                    fee = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(fee), fee, $"{nameof(Balance)} cannot be less than 0.0. ");
                }
            }
        }

        /// <summary>
        /// Method that overrides credit method from base class
        /// </summary>
        /// <param name="amount"></param>
        public override void Credit(decimal amount)
        {
            base.Credit(amount);
            Balance -= Fee;
        }

        /// <summary>
        /// Method that overrides debit method from base class
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public override bool Debit(decimal amount)
        {
            if (base.Debit(amount))
            {
                return true;
            }
            return false;
        }
    }
}