using calc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Calc.Tests
{
    [TestFixture]
    public class CalculatorTester
    {
        // Step 6. Add the definition of the mock objects
        private IUSD_CLP_ExchangeRateFeed prvGetMockExchangeRateFeed()
        {
            Mock<IUSD_CLP_ExchangeRateFeed> mockObject = new Mock<IUSD_CLP_ExchangeRateFeed>();
            mockObject.Setup(m => m.GetActualUSDValue()).Returns(500);
            return mockObject.Object;
        }
        // Step 7. Add the test methods for each test case
        [Test(Description = "Divide 9 by 3. Expected result is 3.")]
        public void TC1_Divide9By3()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 3);
            int expectedResult = 3;
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test(Description = "Divide any number by zero. Should throw an System.DivideByZeroException exception.")]
        [ExpectedException(typeof(System.DivideByZeroException))]
        public void TC2_DivideByZero()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.Divide(9, 0);
        }
        [Test(Description = "Convert 1 USD to CLP. Expected result is 500.")]
        public void TC3_ConvertUSDtoCLPTest()
        {
            IUSD_CLP_ExchangeRateFeed feed = this.prvGetMockExchangeRateFeed();
            ICalculator calculator = new Calculator(feed);
            int actualResult = calculator.ConvertUSDtoCLP(1);
            int expectedResult = 500;
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
