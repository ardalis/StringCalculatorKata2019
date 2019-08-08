using Xunit;

namespace StringCalculatorKata
{
    public class CalculatorAdd
    {
        [Fact]
        public void Returns0GivenEmptyString()
        {
            var calculator = new Calculator();

            var result = calculator.Add("");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Returns0GivenSingle0String()
        {
            var calculator = new Calculator();

            var result = calculator.Add("0");

            Assert.Equal(0, result);
        }

        [Fact]
        public void Returns1GivenSingle1String()
        {
            var calculator = new Calculator();

            var result = calculator.Add("1");

            Assert.Equal(1, result);
        }
    }
}
