using System.Linq;
using GG;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGTests
{
    [TestClass]
    public class FullPrimeTests
    {
        [TestMethod]
        public void TestCheck()
        {
            var res = FullPrime.Check(2, new []{53, 41});
            Assert.IsTrue(new[] { true, false }.SequenceEqual(res));
        }
    }
}
