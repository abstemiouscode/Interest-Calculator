using System;
using System.Windows.Forms;
using InterestCalculator.Models;
using InterestCalculator.Presenters;
using GlobalResources.Properties;

namespace InterestCalculator.Views
{
    public partial class InterestCalculator : Form, ICalculateView
    {
        #region Declarations

        private CalculationPresenter _calculationPresenter;
        private Validator _validator;

        #endregion Declarations

        #region Delegates and Events
        #endregion Delegates and Events

        #region Constructor and Destructors

        public InterestCalculator()
        {
            InitializeComponent();
            _validator = new Validator();
            _calculationPresenter = new CalculationPresenter(this, _validator);
            this.btnReset.Click += BtnReset_Click;
            this.btnCalculate.Click += BtnCalculate_Click;
            this.Load += InterestCalculator_Load;
            this.Icon = Resources.redIcon;
        }

        #endregion Constructor and Destructors

        #region Form event handlers

        /// <summary>
        /// Load event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterestCalculator_Load(object sender, EventArgs e)
        {
            ClearInputControls();
        }

        #endregion Form event handlers

        #region UI Events

        /// <summary>
        /// Initial balance text changed event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtInitialBalance_TextChanged(object sender, EventArgs e)
        {
            CalculationModel calculationModel = new CalculationModel();
            calculationModel.InitialBalanceText = txtInitialBalance.Text.Trim();

            if (string.IsNullOrEmpty(calculationModel.InitialBalanceText))
            {
                lblRates.Text = "%";
                return;
            }

            _calculationPresenter.ReturnCalculatedRate(calculationModel);
        }

        #endregion

        #region Button and Menu event handlers

        /// <summary>
        /// Reset button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearInputControls();
        }

        /// <summary>
        /// Calculate button click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            CalculationModel calculationModel = new CalculationModel();
            calculationModel.InitialBalanceText = txtInitialBalance.Text.Trim();
            calculationModel.InterestRateText = lblRates.Text.Replace("%", string.Empty);
            calculationModel.NumberOfYearsText = nudAmountOfYears.Value.ToString();

            _calculationPresenter.ReturnCalculatedTotal(calculationModel);

        }

        #endregion Button and Menu event handlers

        #region Public Procedures/methods

        /// <summary>
        /// Clears the input controls
        /// </summary>
        public void ClearInputControls()
        {
            txtInitialBalance.Text = txtTotalResult.Text = txtInterestEarned.Text = string.Empty;
            nudAmountOfYears.Value = 1;
            lblRates.Text = "%";
        }

        /// <summary>
        /// Shows validation message
        /// </summary>
        /// <param name="message"></param>
        public void ShowMessage(string message)
        {
            MessageBox.Show(message, "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Returns the total result
        /// </summary>
        /// <param name="calculation"></param>
        public void ReturnTotalResult(CalculationModel calculation)
        {
            txtTotalResult.Text = calculation.ResultAmountText;
            txtInterestEarned.Text = calculation.InterestEarnedText;
        }

        /// <summary>
        /// Returns the interest rate 
        /// </summary>
        /// <param name="calculation"></param>
        public void ReturnInterestRate(CalculationModel calculation)
        {
            lblRates.Text = $"{calculation.InterestRateText}%";
        }

        #endregion Public Procedures/methods

    }
}
