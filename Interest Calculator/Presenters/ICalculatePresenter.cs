using InterestCalculator.Models;

namespace InterestCalculator.Presenters
{
    public interface ICalculatePresenter
    {
        /// <summary>
        /// Calculate compound interest 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="interest"></param>
        /// <param name="years"></param>
        /// <param name="interestEarned"></param>
        /// <returns></returns>
        decimal CalculateCompoundInterest(string amount, string interest, string years, out decimal interestEarned);


        /// <summary>
        /// Calculate the rates of interest 
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <returns></returns>
        double CalculateInterestRate(string initialBalance);

        /// <summary>
        /// Convert the passed in string into a double
        /// </summary>
        /// <param name="passedString"></param>
        /// <returns></returns>
        double ConvertStringToDouble(string passedString);

        /// <summary>
        /// Convert the passed in string into an int 
        /// </summary>
        /// <param name="passedString"></param>
        /// <returns></returns>
        int ConvertStringToInt(string passedString);

        /// <summary>
        /// Calculate rate of interest and update 
        /// </summary>
        /// <param name="calculationModel"></param>
        void ReturnCalculatedRate(CalculationModel calculationModel);

        /// <summary>
        /// Calculate interest rate and update
        /// </summary>
        /// <param name="calculationModel"></param>
        void ReturnCalculatedTotal(CalculationModel calculationModel);
    } 
}
