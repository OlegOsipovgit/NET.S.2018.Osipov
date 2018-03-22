using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EvklidNOD;

namespace NUnit.Tests1EvklidNOD
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod1()
        {
            double expected = 3;
            double actual = EvklidClass.NODofElementsEvklid(9, 6);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void TestMethod2()
        {
            double expected = 3;
            double actual = EvklidClass.NODofElementsStein(9, 6);
            Assert.AreEqual(expected, actual);
        }

    }
}
