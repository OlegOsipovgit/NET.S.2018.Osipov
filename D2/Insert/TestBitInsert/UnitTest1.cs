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
            int expected = 81;
            int actual = InsertNumber.Insert(33,5,3,7);
           Assert.AreEqual(expected, actual);
        }
    }
}
