using InterestCalculator;
using InterestCalculator.Presenters;
using InterestCalculator.Views;
using NSubstitute;
using NUnit.Framework;

namespace InterestCalculatorTests.Presenters
{
    [TestFixture]
    public class CalculationPresenterTests
    {
        private ICalculateView view;

        private IValidator validate;

        private CalculationPresenter presenter;

        [SetUp]
        public void StartUp()
        {
            view = Substitute.For<ICalculateView>();
            validate = Substitute.For<IValidator>(); 
             presenter = new CalculationPresenter(view, validate);
        }
    
        [Test]
        public void ExpectToCalculateInterestRate()
        {
            StartUp();

            string initialBalance = "1000";

            double expectedInterestRate = 1.5;  

            double resultInterestRate = presenter.CalculateInterestRate(initialBalance);

            Assert.AreEqual(resultInterestRate, expectedInterestRate);
        }

        [Test]
        public void ExpectToConvertStringToDouble()
        {
            StartUp();

            string initialBalance = "1000";
            double expectedDouble = 1000;      

            double resultDouble = presenter.ConvertStringToDouble(initialBalance);

            Assert.AreEqual(resultDouble, expectedDouble);
        }

        [Test]
        public void ExpectToConvertStringToInt()
        {
            StartUp();

            string initialBalance = "1000";
            int expectedInt = 1000;      

            int resultInt = presenter.ConvertStringToInt(initialBalance);

            Assert.AreEqual(resultInt, expectedInt);
        }

        [Test]
        public void ExpectToCalculateCompoundInterest()
        {
            StartUp();

            string initialBalance = "1000";
            string interest = "1.5";
            string numberOfYears = "3";

            decimal expectedResultTotalDecimal = 1045.678375M;
            decimal expectedInterestEarned = 45.6783749999995M; 
          
            decimal totalResultDecimal = presenter.CalculateCompoundInterest(initialBalance, interest, numberOfYears, out decimal interestEarnedDecimal);

            Assert.AreEqual(totalResultDecimal, expectedResultTotalDecimal);
            Assert.AreEqual(interestEarnedDecimal, expectedInterestEarned);
        }
    }
}
