using NUnit.Framework;
using UnitTestsExample;

namespace CalculatorUnitTest
{
    public class Tests
    {

        [Test]
        public void AddNumbers_FiveTenFifteen_ShouldReturnThirty() {
            Calculator calculator = new Calculator();
            int sum = calculator.AddNumbers(5, 10, 15);
            Assert.AreEqual(30, sum);
        }

        [Test]
        public void MaxNumber_FiveTenFifteen_ShouldReturnFifteen() {
            Calculator calculator = new Calculator();
            int maxValue = calculator.MaxValue(5, 10, 15);
            Assert.AreEqual(15, maxValue);
        }

        [Test]
        public void MinNumber_FiveTenFifteen_ShouldReturnFive() {
            Calculator calculator = new Calculator();
            int minValue = calculator.MinValue(5, 10, 15);
            Assert.AreEqual(5, minValue);
        }

        [Test]
        public void Average_FiveTenFifteen_ShouldReturnFifteen() {
            Calculator calculator = new Calculator();
            float average = calculator.CalculateAverage(5, 10, 15);
            Assert.AreEqual(10f, average);
        }

    }
}