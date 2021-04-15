using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinearDataStructures;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAddFirstToEmptyList()
        {
            LinkedList list = new LinkedList();
            list.AddFirst(3);
            Assert.AreEqual(1, list.Count);
            Assert.AreEqual(list.First, list.Last);
            Assert.IsTrue(list.Last != null);
        }
        [TestMethod]
        public void TestAddFirstForTwoElements()
        {
            LinkedList list = new LinkedList();
            list.AddFirst(3);
            list.AddFirst(7);
            Assert.AreEqual(2, list.Count);
            Assert.AreEqual(list.First.Next, list.Last);
            Assert.IsTrue(list.Last != null);

        }
    }
}
