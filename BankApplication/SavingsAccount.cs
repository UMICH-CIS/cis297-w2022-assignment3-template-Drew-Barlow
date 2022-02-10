using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BankApplication
{
    /// <summary>
    /// Class for the savings account that inherits from base class Account
    /// </summary>
    public class SavingsAccount : Account
    {
        private decimal InterestRate;

        public SavingsAccount(decimal balance, decimal interestRate) : base(balance)
        {
            Interest = interestRate;
        }

        /// <summary>
        /// Property that initializes the interest rate and validates it
        /// </summary>
        public decimal Interest
        {
            get
            {
                return InterestRate;
            }
            set
            {
                if (value > 0.0m)
                {
                    InterestRate = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(InterestRate), InterestRate, $"{nameof(Balance)} must be greater than 0.0. ");

                }
            }
        }

        /// <summary>
        /// Method to calculate the balance after interest has been applied
        /// </summary>
        /// <returns></returns>
        public decimal CalculateInterest()
        {
            return Balance * InterestRate;
        }
    }
}