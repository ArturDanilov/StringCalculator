using StringCalculator;

namespace StringCalculatorTests
{
    public class AddNumbersTests
    {
        [SetUp]
        public void Setup()
        {
            Calculator calculator = new Calculator();
        }

        [Test]
        public void AddNumbers_InputEmpty_Return0()
        {
            Calculator calculator = new Calculator();

            var actual = calculator.AddNumber("");

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void AddNumbers_Input0_Return0()
        {
            Calculator calculator = new Calculator();

            var actual = calculator.AddNumber("0");

            Assert.AreEqual(0, actual);
        }

        [Test]
        public void AddNumbers_InputOne_Return1()
        {
            Calculator calculator = new Calculator();

            var actual = calculator.AddNumber("1");

            Assert.AreEqual(1, actual);
        }
    }
}