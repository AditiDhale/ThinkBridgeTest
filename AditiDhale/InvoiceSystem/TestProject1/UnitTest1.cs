using UsageBillingApp.Models;
using UsageBillingApp.Services;

namespace TestProject1
{
    [TestFixture]
    public class Tests
    {
        private InvoiceCalculator _calcService;

        [SetUp]
        public void Setup()
        {
            _calcService = new InvoiceCalculator();
        }

        [Test]
        public void Test1()
        {
            // Arrange
            UsageRecord record = new UsageRecord();
            // Act
            var actualResult = _calcService.Calculate(record);
            // Assert
            Assert.Pass();
        }
    }
}
