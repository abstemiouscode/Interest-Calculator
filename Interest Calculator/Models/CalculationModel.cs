namespace InterestCalculator.Models
{
    public class CalculationModel
    {
        #region Methods

        /// <summary>
        /// Initial balance 
        /// </summary>
        public string InitialBalanceText { get; set; }

        /// <summary>
        /// Number of years 
        /// </summary>
        public string NumberOfYearsText { get; set; }

        /// <summary>
        /// Interest rate
        /// </summary>
        public string InterestRateText { get; set; }

        /// <summary>
        /// Interest rate earned
        /// </summary>
        public string InterestEarnedText { get; set; }

        /// <summary>
        /// Result amount
        /// </summary>
        public string ResultAmountText { get; set; }

        #endregion
    }
}
