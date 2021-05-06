namespace RPNCalculator
{
    public class RPNCalculatorEngine
    {
        public int Evaluate(string postfixEquation)
        {
            if(postfixEquation.Length == 1)
            {
                return int.Parse(postfixEquation);
            } else
            {
                int operand1 = int.Parse(postfixEquation[0].ToString());
                int operand2 = int.Parse(postfixEquation[2].ToString());
                if (postfixEquation[4] == '+')
                {
                    return operand1 + operand2;
                } else
                {
                    return operand1 - operand2;
                }
            }
        }
    }
}
