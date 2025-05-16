namespace MathsChallenge
{
    public class MathsProvider
    {
        public int DoTheMath(MathsAction mathsAction, int firstNumber, int secondNumber)
        {
            return mathsAction switch
            {
                MathsAction.Addition => Addition(firstNumber, secondNumber),
                MathsAction.Subtraction => Subtraction(firstNumber, secondNumber),
                MathsAction.Multiplication => Mulitplication(firstNumber, secondNumber),
                MathsAction.Division => Division(firstNumber, secondNumber),
                _ => throw new NotImplementedException($"Sorry, action {mathsAction} is not a recognised function!")
            };
        }

        private int Addition(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        private int Subtraction(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        private int Mulitplication(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }

        private int Division(int firstNumber, int secondNumber)
        {
            throw new NotImplementedException();
        }
    }
}