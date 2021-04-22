using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class StackTests
    {
        [TestMethod]
        public void TestAddElementToEmptyStack()
        {
            Stack stack = new Stack();
            stack.Push(5);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(5, stack.Peek());
        }
        [TestMethod]
        public void TestAddTwoElementsToEmptyStack()
        {

        }
        [TestMethod]
        public void TestAddAndRemoveOneElementFromTheStack()
        {

        }
        [TestMethod]
        public void TestAddTwoElementsAndRemoveOneFromTheStack()
        {

        }
    }
}
