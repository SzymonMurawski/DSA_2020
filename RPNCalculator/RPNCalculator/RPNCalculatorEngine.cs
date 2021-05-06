using System.Collections.Generic;

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
                var operandsStack = new Stack<double>();
                foreach (string element in elements)
                {
                    if (double.TryParse(element, out double number))
                    {
                        operandsStack.Push(number);
                    } else
                    {
                        double operand2 = operandsStack.Pop();
                        double operand1 = operandsStack.Pop();
                        string operatorSymbol = element;
                        operandsStack.Push(EvaluateExpression(operand1, operand2, operatorSymbol));
                    }
                }
                return operandsStack.Pop();
            }
        }

        private static double EvaluateExpression(double operand1, double operand2, string operatorSymbol)
        {
            if (operatorSymbol == "+")
            {
                return operand1 + operand2;
            }
            else
            {
                return operand1 - operand2;
            }
        }
    }
}
