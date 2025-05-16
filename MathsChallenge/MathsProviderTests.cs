namespace MathsChallenge
{
    public class Tests
    {
        private MathsProvider sut;

        [SetUp]
        public void Setup()
        {
            sut = new MathsProvider();
        }

        [TestCase(5, 5, 10)]
        [TestCase(13, 4, 17)]
        [TestCase(12, 34, 46)]
        [TestCase(-15, 8, -7)]
        [TestCase(-24, -16, -40)]
        public void When_calling_DoTheMath_with_addition_and_two_numbers_the_return_value_is_added_correctly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = sut.DoTheMath(MathsAction.Addition, firstNumber, secondNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(5, 5, 0)]
        [TestCase(13, 4, 9)]
        [TestCase(12, 34, -22)]
        [TestCase(-15, 8, -23)]
        [TestCase(-24, -16, -8)]
        public void When_calling_DoTheMath_with_subtraction_and_two_numbers_the_return_value_is_subtracted_correctly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = sut.DoTheMath(MathsAction.Subtraction, firstNumber, secondNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(20, 5, 100)]
        [TestCase(6, 4, 24)]
        [TestCase(12, 6, 72)]
        [TestCase(10, 8, 80)]
        [TestCase(2, 30, 60)]
        [TestCase(-10, -8, 80)]
        public void When_calling_DoTheMath_with_multiplication_and_two_numbers_the_return_value_is_subtracted_correctly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = sut.DoTheMath(MathsAction.Multiplication, firstNumber, secondNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }

        [TestCase(25, 5, 5)]
        [TestCase(16, 4, 4)]
        [TestCase(12, 3, 4)]
        [TestCase(60, 20, 3)]
        [TestCase(30, 2, 15)]
        [TestCase(-60, -20, 3)]
        public void When_calling_DoTheMath_with_division_and_two_numbers_the_return_value_is_subtracted_correctly(int firstNumber, int secondNumber, int expectedResult)
        {
            var result = sut.DoTheMath(MathsAction.Division, firstNumber, secondNumber);

            Assert.That(result, Is.EqualTo(expectedResult));
        }
    }
}