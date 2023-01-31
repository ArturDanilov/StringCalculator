using StringCalculator;

namespace StringCalculatorTests
{
    public class AddNumbersTests
    {

        Calculator _calculator = new Calculator();
        [SetUp]
        public void Setup()
        {
            _calculator = new Calculator();
        }
        [TearDown]
        public void TearDown()
        {
            _calculator = null;
        }

        [Test]
        public void AddNumbers_InputEmpty_Return0()
        {
            var actual = _calculator.Add("");

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void AddNumbers_Input0_Return0()
        {
            var actual = _calculator.Add("0");

            Assert.That(actual, Is.EqualTo(0));
        }

        [Test]
        public void AddNumbers_InputOne_Return1()
        {
            var actual = _calculator.Add("1");


            Assert.That(actual, Is.EqualTo(1));
        }

        [Test]
        public void AddNumbers_InputTwoNumbers_ReturnCorrectResult()
        {
            var actual = _calculator.Add("2 + 2");

            Assert.That(actual, Is.EqualTo(4));
        }

        [Test]
        public void AddNumbers_DelimeterPlus_ReturnCorrectResult()
        {
            var actual = _calculator.Add("1 + 2");

            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void AddNumbers_DelimeterMinus_ReturnCorrectResult()
        {
            var actual = _calculator.Add("5 - 2");

            Assert.That(actual, Is.EqualTo(3));
        }

        [Test]
        public void AddNumbers_DelimeterStar_ReturnCorrectResult()
        {
            var actual = _calculator.Add("3 * 5");

            Assert.That(actual, Is.EqualTo(15));
        }

        [Test]
        public void AddNumbers_DelimeterSlash_ReturnCorrectResult()
        {
            var actual = _calculator.Add("15 / 3");

            Assert.That(actual, Is.EqualTo(5));
        }

        [Test]
        public void AddNumbers_MoreDelimeter_ReturnCorrectResult()
        {
            var actual = _calculator.Add("1    +    2");

            Assert.That(actual, Is.EqualTo(3));
        }
    }
}