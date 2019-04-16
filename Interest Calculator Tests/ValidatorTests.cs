using InterestCalculator;
using NUnit.Framework;
using GlobalResources.Properties;

namespace InterestCalculatorTests
{
    [TestFixture]
    public class ValidatorTests
    {
        private Validator validator;

        [SetUp]
        public void StartUp()
        {
            validator = new Validator();          
        }

        [Test]
        public void ExpectToFailValidationIfInitialBalanceIsEmpty()
        {
            StartUp();
            bool result = validator.ValidateInitialBalance(string.Empty, out string message);
            Assert.IsFalse(result);
        }

        [Test]
        public void ExpectToReturnAppropriateMessageIfInitialBalanceIsEmpty()
        {
            StartUp();
            bool result = validator.ValidateInitialBalance(string.Empty, out string message);
            Assert.AreEqual(Resources.BalanceAmountEmpty, message);

        }

        [Test]
        public void ExpectToPassValidationIfInitialBalanceIsNotEmpty()
        {
            StartUp();
            bool result = validator.ValidateInitialBalance("1000", out string message);
            Assert.IsTrue(result);
        }

        [Test]
        public void ExpectToFailValidationIfNumberOfYearsIsEmpty()
        {
            StartUp();
            bool result = validator.ValidateNumberOfYears(string.Empty, out string message);
            Assert.IsFalse(result);
        }

        [Test]
        public void ExpectToReturnAppropriateMessageIfNumberOfYearsIsEmpty()
        {
            StartUp();
            bool result = validator.ValidateNumberOfYears(string.Empty, out string message);
            Assert.AreEqual(Resources.NumberofYearsEmpty, message);

        }

        [Test]
        public void ExpectToFailValidationIfNumberOfYearsIsNotNumber()
        {
            StartUp();
            bool result = validator.ValidateNumberOfYears("test3", out string message);
            Assert.IsFalse(result);
        }

        [Test]
        public void ExpectToReturnAppropriateMessageIfNumberOfYearsIsNotNumber()
        {
            StartUp();
            bool result = validator.ValidateNumberOfYears("test3", out string message);
            Assert.AreEqual(Resources.NumberofYearsNotInt, message);

        }

        [Test]
        public void ExpectToPassValidationIfNumberOfYearsIsNumber()
        {
            StartUp();
            bool result = validator.ValidateNumberOfYears("2", out string message);
            Assert.IsTrue(result);

        }

        [Test]
        public void ExpectToReturnAppropriateMessageIfInterestRateIsEmpty()
        {
            StartUp();
            bool result = validator.ValidateInterestRate(string.Empty, out string message);
            Assert.AreEqual(Resources.InterestRateEmpty, message);
        }

        [Test]
        public void ExpectToFailValidationIfInterestRateIsDouble()
        {
            StartUp();
            bool result = validator.ValidateInterestRate("test3", out string message);
            Assert.IsFalse(result);
        }

        [Test]
        public void ExpectToReturnAppropriateMessageIfInterestRateIsNotDouble()
        {
            StartUp();
            bool result = validator.ValidateInterestRate("test3", out string message);
            Assert.AreEqual(Resources.InterestRateNotDouble, message);

        }

        [Test]
        public void ExpectToPassValidationIfInterestRateIsDouble()
        {
            StartUp();
            bool result = validator.ValidateInterestRate("2", out string message);
            Assert.IsTrue(result);

        }
    }
}
