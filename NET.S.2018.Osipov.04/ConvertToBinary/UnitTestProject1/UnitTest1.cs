using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConvertToBinary;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            List<int> number = new List<int>() { 5 };
            List<int> expected = new List<int>() { 1, 0, 1 };
            List <int> actual = Class1.ConvertToBinaryExtension(5);
            Assert.AreEqual(expected, actual);
        }
    }
}
