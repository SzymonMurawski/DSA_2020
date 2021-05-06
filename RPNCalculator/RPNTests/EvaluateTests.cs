using Microsoft.VisualStudio.TestTools.UnitTesting;
using RPNCalculator;

namespace RPNTests
{
    [TestClass]
    public class EvaluateTests
    {
        readonly RPNCalculatorEngine rpnCalculator = new RPNCalculatorEngine();
        [TestMethod]
        public void TestEvaluateSingleNumber()
        {
            Assert.AreEqual(5, rpnCalculator.Evaluate("5"));
        }

        [TestMethod]
        public void TestAddTwoNumbers()
        {
            Assert.AreEqual(5, rpnCalculator.Evaluate("2 3 +"));
        }
        [TestMethod]
        public void TestSubstractTwoNumbers()
        {
            Assert.AreEqual(1, rpnCalculator.Evaluate("3 2 -"));
        }
    }
}
