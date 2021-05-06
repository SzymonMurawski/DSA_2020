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
                return int.Parse(postfixEquation[0].ToString())
                + int.Parse(postfixEquation[2].ToString());
            }
            
        }
    }
}
