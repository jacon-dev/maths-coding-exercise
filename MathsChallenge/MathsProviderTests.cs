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
        public void When_calling_DoTheMath_with_addition_and_two_numbers_the_return_value_is_added_correctly(int firstNumber, int secondNumber, int expectedResult)
        {
            Assert.Fail();
        }
    }
}