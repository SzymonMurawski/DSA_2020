using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace UnitTestProject1
{
    [TestClass]
    public class SortingTests
    {
        [TestMethod]
        public void TestInsertionSort()
        {
            var sortEngine = new InsertionSort();
            int[] array = new int[] { 5, 4, 3, 2, 1 };
            sortEngine.Sort(array);
            CollectionAssert.AreEqual(array, new int[] { 1, 2, 3, 4, 5 });
        }
    }
}
