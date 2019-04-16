using System;
using InterestCalculator.Models;
using InterestCalculator.Views;

namespace InterestCalculator.Presenters
{
    public class CalculationPresenter: ICalculatePresenter
    {
        #region Declarations

        /// <summary>
        /// calculator view interface
        /// </summary>
        private ICalculateView _view;

        /// <summary>
        /// validate interface
        /// </summary>
        private IValidator _validator;

        #endregion Declarations

        #region Constructor and Destructors

        /// <summary>
        /// Class Constructor
        /// </summary>
        /// <param name="view"></param>
        /// <param name="validator"></param>
        public CalculationPresenter(ICalculateView view, IValidator validator)
        {
            this._view = view;
            this._validator = validator;
        }

        #endregion Constructor and Destructors

        #region  Mmethods

        /// <summary>
        /// Calculate rate of interest and update 
        /// </summary>
        /// <param name="calculationModel"></param>
        public void ReturnCalculatedRate(CalculationModel calculationModel)
        {
            string validationMessage = string.Empty;
            if (!_validator.ValidateInitialBalance(calculationModel.InitialBalanceText, out validationMessage))
            {
                _view.ShowMessage(validationMessage);
                return;
            }

            calculationModel.InterestRateText = CalculateInterestRate(calculationModel.InitialBalanceText).ToString();
            _view.ReturnInterestRate(calculationModel);
        }

        /// <summary>
        /// Calculate interest rate and update
        /// </summary>
        /// <param name="calculationModel"></param>
        public void ReturnCalculatedTotal(CalculationModel calculationModel)
        {
            string validationMessage = string.Empty;

            if (!_validator.ValidateInitialBalance(calculationModel.InitialBalanceText, out validationMessage) || 
                !_validator.ValidateNumberOfYears(calculationModel.NumberOfYearsText, out validationMessage) || !_validator.ValidateInterestRate(calculationModel.NumberOfYearsText, out validationMessage))
            {
                _view.ShowMessage(validationMessage);
                return;
            }

            calculationModel.ResultAmountText = CalculateCompoundInterest(calculationModel.InitialBalanceText, calculationModel.InterestRateText, calculationModel.NumberOfYearsText, out decimal interestEarned).ToString("C0");
            calculationModel.InterestEarnedText = interestEarned.ToString("C0");

            _view.ReturnTotalResult(calculationModel);
        }

        /// <summary>
        /// Calculate compound interest 
        /// </summary>
        /// <param name="amount"></param>
        /// <param name="interest"></param>
        /// <param name="years"></param>
        /// <param name="interestEarned"></param>
        /// <returns></returns>
        public decimal CalculateCompoundInterest(string amount, string interest, string years, out decimal interestEarned)
        {
            double annualRate = ConvertStringToDouble(interest) / 100;
            double principal  = ConvertStringToDouble(amount);
            int numberOfYears = ConvertStringToInt(years);

            double iE = 0;
            double i = annualRate / 1;
            int n    = 1 * numberOfYears;

            double futureValue = principal * Math.Pow(1+i, n);
            iE = futureValue - principal;

            interestEarned = (decimal) iE;

            return (decimal) futureValue;
        }

        /// <summary>
        /// Calculate the rates of interest
        /// </summary>
        /// <param name="initialBalance"></param>
        /// <returns></returns>
        public double CalculateInterestRate(string initialBalance)
        {
            double interest = 0;
            double amount = ConvertStringToDouble(initialBalance);

            if (amount < 1000)
                interest = 1;

            if (amount >= 1000 && amount <= 5000)
                interest = 1.5;

            if (amount >= 5000 && amount <= 10000)
                interest = 2;

            if (amount >= 10000 && amount <= 50000)
                interest = 2.5;

            if (amount > 50000)
                interest = 3;

            return interest;
        }

        /// <summary>
        /// Convert the passed in string into a double
        /// </summary>
        /// <param name="passedString"></param>
        /// <returns></returns>
        public double ConvertStringToDouble(string passedString)
        {
            double result;

            double.TryParse(passedString, out result);

            return result;
        }

        /// <summary>
        /// Convert the passed in string into an int 
        /// </summary>
        /// <param name="passedString"></param>
        /// <returns></returns>
        public int ConvertStringToInt(string passedString)
        {
            int result;

            int.TryParse(passedString, out result);

            return result;
        }

        #endregion Methods
    }
}
