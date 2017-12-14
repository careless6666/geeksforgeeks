using GG.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGTests.Easy
{
    /// <summary>
    /// Summary description for LengthOfLongestBalancedParenthesesPrefixTest
    /// </summary>
    [TestClass]
    public class LengthOfLongestBalancedParenthesesPrefixTest
    {
        [TestMethod]
        public void TestCheck()
        {
            var s = "((()())())((";
            var res = LengthOfLongestBalancedParenthesesPrefix.Check(s);

            Assert.AreEqual(10, res);

            s = "()(())((()";
            res = LengthOfLongestBalancedParenthesesPrefix.Check(s);

            Assert.AreEqual(4, res);
        }

       
    }
}
