using Microsoft.VisualStudio.TestTools.UnitTesting;
using RandomPancakeStack;

namespace RandomPancakeStackTests
{
    [TestClass]
    public class RandomPancakeStackTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var r = new RandomPancakeStackDiv2();
            var result = r.expectedDeliciousness(new[] {1, 1, 1, 1});
            Assert.AreEqual(1.6666666666666667, result);
        }
    }
}
