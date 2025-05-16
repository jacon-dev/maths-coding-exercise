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
    }
}