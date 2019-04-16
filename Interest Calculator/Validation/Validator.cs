using GlobalResources.Properties;

namespace InterestCalculator
{
    public class Validator: IValidator
    {
        /// <summary>
        /// Validates the initial balance
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        public bool ValidateInitialBalance(string initialBalance, out string validationMessage)
        {
            if (string.IsNullOrEmpty(initialBalance))
            {
                validationMessage = Resources.BalanceAmountEmpty;
                return false;
            }

            int amount;

            if (!int.TryParse(initialBalance, out amount))
            {
                validationMessage = Resources.BalanceAmountNotInt;
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }

        /// <summary>
        /// Validates the interest rate 
        /// </summary>
        /// <param name="interestRate"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        public bool ValidateInterestRate(string interestRate, out string validationMessage)
        {
            if (string.IsNullOrEmpty(interestRate))
            {
                validationMessage = Resources.InterestRateEmpty;
                return false;
            }

            double rate;

            if (!double.TryParse(interestRate, out rate))
            {
                validationMessage = Resources.InterestRateNotDouble;
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }

        /// <summary>
        /// Validates the number of years 
        /// </summary>
        /// <param name="amountOfDays"></param>
        /// <param name="validationMessage"></param>
        /// <returns></returns>
        public bool ValidateNumberOfYears(string amountOfDays, out string validationMessage)
        {
            if (string.IsNullOrEmpty(amountOfDays))
            {
                validationMessage = Resources.NumberofYearsEmpty;
                return false;
            }

            int numberofYears;

            if (!int.TryParse(amountOfDays, out numberofYears))
            {
                validationMessage = Resources.NumberofYearsNotInt;
                return false;
            }

            validationMessage = string.Empty;
            return true;
        }
    }
}
