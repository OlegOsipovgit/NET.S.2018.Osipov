using System;
using EvklidNOD;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectEvklidNOD
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 3;
            double actual = EvklidClass.NODofElementsEvklid(9,6);
            Assert.AreEqual(expected, actual);
        }
    
    }
}
