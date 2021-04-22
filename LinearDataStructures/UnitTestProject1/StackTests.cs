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
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(5, stack.Peek());
        }
        [TestMethod]
        public void TestAddTwoElementsToEmptyStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            Assert.AreEqual(2, stack.Count);
            Assert.AreEqual(3, stack.Peek());
        }
        [TestMethod]
        public void TestAddAndRemoveOneElementFromTheStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            int value = stack.Pop();
            Assert.AreEqual(0, stack.Count);
            Assert.AreEqual(5, value);
            Assert.ThrowsException<System.NullReferenceException>( () => stack.Peek() ); // lambda function
        }
        [TestMethod]
        public void TestAddTwoElementsAndRemoveOneFromTheStack()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            int value = stack.Pop();
            Assert.AreEqual(1, stack.Count);
            Assert.AreEqual(5, stack.Peek());
            Assert.AreEqual(3, value);
        }
    }
}
