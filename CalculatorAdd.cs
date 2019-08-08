using Xunit;

namespace StringCalculatorKata
{
    public class CalculatorAdd
    {
        private Calculator _calculator;

        public CalculatorAdd()
        {
            // You'd use a [SetUp] method here if using NUnit
            _calculator = new Calculator();
        }

        [Fact]
        public void Returns0GivenEmptyString()
        {
            var result = _calculator.Add("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Returns0GivenSingle0String()
        {
            var result = _calculator.Add("0");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Returns1GivenSingle1String()
        {
            var result = _calculator.Add("1");

            Assert.Equal(1, result);
        }
    }
}
