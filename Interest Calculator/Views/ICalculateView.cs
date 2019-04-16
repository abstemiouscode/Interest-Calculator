using InterestCalculator.Models;

namespace InterestCalculator.Views
{
    public interface ICalculateView
    {
        #region Events
        #endregion

        #region Methods

        /// <summary>
        /// Clears the Controls
        /// </summary>
        void ClearInputControls();

        /// <summary>
        /// Shows the validation message
        /// </summary>
        /// <param name="message"></param>
        void ShowMessage(string message);

        /// <summary>
        /// Returns the total result
        /// </summary>
        /// <param name="calculationModel"></param>
        void ReturnTotalResult(CalculationModel calculationModel);

        /// <summary>
        /// Returns the interest rate 
        /// </summary>
        /// <param name="calculationModel"></param>
        void ReturnInterestRate(CalculationModel calculationModel);

        #endregion
    }
}