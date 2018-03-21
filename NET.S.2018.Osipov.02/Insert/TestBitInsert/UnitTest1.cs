using System;
using BitInsert;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestBitInsert
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int expected = 15;
            int actual = InsertNumber.Insert(9, 3, 1, 2);
            Assert.AreEqual(expected, actual);
        }
    }
}