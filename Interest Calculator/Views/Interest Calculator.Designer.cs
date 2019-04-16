using System;

namespace InterestCalculator.Views
{
    partial class InterestCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBalanceAmount = new System.Windows.Forms.Label();
            this.txtInitialBalance = new System.Windows.Forms.TextBox();
            this.lblAmountOfYears = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtTotalResult = new System.Windows.Forms.TextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.nudAmountOfYears = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.lblRates = new System.Windows.Forms.Label();
            this.txtInterestEarned = new System.Windows.Forms.TextBox();
            this.lblInterestEarned = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfYears)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBalanceAmount
            // 
            this.lblBalanceAmount.AutoSize = true;
            this.lblBalanceAmount.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblBalanceAmount.Location = new System.Drawing.Point(23, 23);
            this.lblBalanceAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBalanceAmount.Name = "lblBalanceAmount";
            this.lblBalanceAmount.Size = new System.Drawing.Size(89, 17);
            this.lblBalanceAmount.TabIndex = 0;
            this.lblBalanceAmount.Text = "Initial Balance:";
            // 
            // txtInitialBalance
            // 
            this.txtInitialBalance.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInitialBalance.Location = new System.Drawing.Point(116, 19);
            this.txtInitialBalance.Margin = new System.Windows.Forms.Padding(2, 10, 2, 10);
            this.txtInitialBalance.Name = "txtInitialBalance";
            this.txtInitialBalance.Size = new System.Drawing.Size(198, 25);
            this.txtInitialBalance.TabIndex = 1;
            this.txtInitialBalance.TextChanged += new System.EventHandler(this.txtInitialBalance_TextChanged);
            // 
            // lblAmountOfYears
            // 
            this.lblAmountOfYears.AutoSize = true;
            this.lblAmountOfYears.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblAmountOfYears.Location = new System.Drawing.Point(55, 91);
            this.lblAmountOfYears.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAmountOfYears.Name = "lblAmountOfYears";
            this.lblAmountOfYears.Size = new System.Drawing.Size(54, 17);
            this.lblAmountOfYears.TabIndex = 4;
            this.lblAmountOfYears.Text = "# Years:";
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnReset.Location = new System.Drawing.Point(255, 203);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 25);
            this.btnReset.TabIndex = 7;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.btnCalculate.Location = new System.Drawing.Point(155, 203);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(96, 25);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // txtTotalResult
            // 
            this.txtTotalResult.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtTotalResult.Location = new System.Drawing.Point(113, 161);
            this.txtTotalResult.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.txtTotalResult.Name = "txtTotalResult";
            this.txtTotalResult.ReadOnly = true;
            this.txtTotalResult.Size = new System.Drawing.Size(198, 25);
            this.txtTotalResult.TabIndex = 10;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblResult.Location = new System.Drawing.Point(70, 165);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(39, 17);
            this.lblResult.TabIndex = 9;
            this.lblResult.Text = "Total:";
            // 
            // nudAmountOfYears
            // 
            this.nudAmountOfYears.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.nudAmountOfYears.Location = new System.Drawing.Point(113, 87);
            this.nudAmountOfYears.Margin = new System.Windows.Forms.Padding(2, 3, 2, 10);
            this.nudAmountOfYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAmountOfYears.Name = "nudAmountOfYears";
            this.nudAmountOfYears.Size = new System.Drawing.Size(42, 25);
            this.nudAmountOfYears.TabIndex = 11;
            this.nudAmountOfYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Interest Rate:";
            // 
            // lblRates
            // 
            this.lblRates.AutoSize = true;
            this.lblRates.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblRates.Location = new System.Drawing.Point(113, 57);
            this.lblRates.Margin = new System.Windows.Forms.Padding(2, 3, 2, 10);
            this.lblRates.Name = "lblRates";
            this.lblRates.Size = new System.Drawing.Size(19, 17);
            this.lblRates.TabIndex = 13;
            this.lblRates.Text = "%";
            // 
            // txtInterestEarned
            // 
            this.txtInterestEarned.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.txtInterestEarned.Location = new System.Drawing.Point(113, 124);
            this.txtInterestEarned.Margin = new System.Windows.Forms.Padding(2, 2, 2, 10);
            this.txtInterestEarned.Name = "txtInterestEarned";
            this.txtInterestEarned.ReadOnly = true;
            this.txtInterestEarned.Size = new System.Drawing.Size(198, 25);
            this.txtInterestEarned.TabIndex = 15;
            // 
            // lblInterestEarned
            // 
            this.lblInterestEarned.AutoSize = true;
            this.lblInterestEarned.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.lblInterestEarned.Location = new System.Drawing.Point(10, 128);
            this.lblInterestEarned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInterestEarned.Name = "lblInterestEarned";
            this.lblInterestEarned.Size = new System.Drawing.Size(99, 17);
            this.lblInterestEarned.TabIndex = 14;
            this.lblInterestEarned.Text = "Interest Earned:";
            // 
            // InterestCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 239);
            this.Controls.Add(this.txtInterestEarned);
            this.Controls.Add(this.lblInterestEarned);
            this.Controls.Add(this.lblRates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudAmountOfYears);
            this.Controls.Add(this.txtTotalResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblAmountOfYears);
            this.Controls.Add(this.txtInitialBalance);
            this.Controls.Add(this.lblBalanceAmount);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(369, 278);
            this.MinimumSize = new System.Drawing.Size(369, 278);
            this.Name = "InterestCalculator";
            this.Text = "Interest Calculator";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.InterestCalculator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAmountOfYears)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBalanceAmount;
        private System.Windows.Forms.TextBox txtInitialBalance;
        private System.Windows.Forms.Label lblAmountOfYears;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtTotalResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown nudAmountOfYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRates;
        private System.Windows.Forms.TextBox txtInterestEarned;
        private System.Windows.Forms.Label lblInterestEarned;
    }
}

