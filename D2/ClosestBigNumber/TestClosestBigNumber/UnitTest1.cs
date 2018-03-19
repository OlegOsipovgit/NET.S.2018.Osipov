using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClosestBigNumber;

namespace TestClosestBigNumber
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int Expected = 21;
            int Actual = Searching.FindNextBiggerNumber(12);
            Assert.AreEqual(Array.Sort(Searching.GetNum(Expected)), Array.Sort(Searching.GetNum(Actual));

        }
    }
}
