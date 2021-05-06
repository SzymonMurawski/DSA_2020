using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculator;

namespace RPNTests
{
    [TestClass]
    public class EvaluateTests
    {
        [TestMethod]
        public void TestEvaluateSingleNumber()
        {
            var rpnCalculator = new RPNCalculatorEngine();
            Assert.AreEqual(5, rpnCalculator.Evaluate("5"));
        }
    }
}
