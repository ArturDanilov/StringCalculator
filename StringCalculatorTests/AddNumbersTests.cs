using StringCalculator;

namespace StringCalculatorTests
{
    public class AddNumbersTests
    {
        [SetUp]
        public void Setup()
        {
        }

        Calculator _calculator = new Calculator();

        [Test]
        public void AddNumbers_InputEmpty_Return0()
        {
            var actual = _calculator.AddAndParseNumber("");

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void AddNumbers_Input0_Return0()
        {
            var actual = _calculator.AddAndParseNumber("0");

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void AddNumbers_InputOne_Return1()
        {
            var actual = _calculator.AddAndParseNumber("1");


            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void AddNumbers_InputTwoNumbers_ReturnCorrectResult()
        {
            var actual = _calculator.AddAndParseNumber("2, 2");

            Assert.That(actual, Is.EqualTo(4));
        }

        [Test]
        public void AddNumbers_DelimeterPlus_ReturnCorrectResult()
        {
            var actual = _calculator.AddAndParseNumber("1+2");

            Assert.That(actual, Is.EqualTo(3));
        }
    }
}