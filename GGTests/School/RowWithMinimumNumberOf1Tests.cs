using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GG.School;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GGTests.School
{
    [TestClass]
    public class RowWithMinimumNumberOf1Tests
    {
        [TestMethod]
        public void TestGetNumber()
        {
            var index = RowWithMinimumNumberOf1.GetNumber(3,3, new [] { 0, 0, 0, 0, 0, 0, 0, 0, 0 });
            Assert.AreEqual(-1, index);

            index = RowWithMinimumNumberOf1.GetNumber(4, 4, new[] { 0, 0, 0, 1, 0, 1, 1, 1, 0, 0, 1, 1, 0, 0, 1, 1 });
            Assert.AreEqual(0, index);

            index = RowWithMinimumNumberOf1.GetNumber(5, 5, 
                new[] { 0, 0, 0, 0, 0,
                        0, 0, 0, 1, 1,
                        0, 0, 1, 1, 1,
                        0, 0, 0, 0, 0,
                        0, 0, 0, 0, 1 });

            Assert.AreEqual(4, index);
        }
    }
}
