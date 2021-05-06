namespace RPNCalculator
{
    public class RPNCalculatorEngine
    {
        public double Evaluate(string postfixEquation)
        {
            if(postfixEquation.Length == 1)
            {
                return int.Parse(postfixEquation);
            } else
            {
                string[] elements = postfixEquation.Split(' ');
                double operand1 = double.Parse(elements[0]);
                double operand2 = double.Parse(elements[1]);
                string operatorSymbol = elements[2];
                if (operatorSymbol == "+")
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
