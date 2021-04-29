using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingAlgorithms;

namespace UnitTestProject1
{
    [TestClass]
    public class ArrayGenerationsTests
    {
        [TestMethod]
        public void TestGenerateAscendingDistribution()
        {
            var generator = new DistributionGenerator();
            int[] array = generator.GenerateAscendingDistribution(5);
            Assert.IsTrue(array[0] < array[1] && array[1] < array[2]);
        }
        [TestMethod]
        public void TestGenerateDescendingDistribution()
        {
            var generator = new DistributionGenerator();
            int[] array = generator.GenerateDescendingDistribution(5);
            Assert.IsTrue(array[0] > array[1] && array[1] > array[2]);
        }
    }
}
