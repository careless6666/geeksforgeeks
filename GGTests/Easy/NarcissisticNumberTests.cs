using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GG.Easy;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGTests.Easy
{
    [TestClass]
    public class NarcissisticNumberTests
    {
        [TestMethod]
        public void TestCheck()
        {
            var res = NarcissisticNumber.Check(153);

            Assert.IsTrue(res);

            res = NarcissisticNumber.Check(1634);

            Assert.IsTrue(res);

            res = NarcissisticNumber.Check(407);

            Assert.IsTrue(res);

            res = NarcissisticNumber.Check(111);

            Assert.IsTrue(!res);
        }
    }
}
