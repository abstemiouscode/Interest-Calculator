using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalculator
{
    public interface IValidator
    {

        /// <summary>
        /// Validates the initial balance
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        bool ValidateInitialBalance(string initialBalance, out string validationMessage);

        /// <summary>
        /// Validates the interest rate 
        /// </summary>
        /// <param name="interestRate"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        bool ValidateInterestRate(string interestRate, out string validationMessage);

        /// <summary>
        /// Validates the number of years 
        /// </summary>
        /// <param name="amountOfDays"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        bool ValidateNumberOfYears(string amountOfDays, out string validationMessage);
    }
}
