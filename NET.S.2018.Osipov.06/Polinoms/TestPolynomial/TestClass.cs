using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Polynom;

namespace TestPolynomial
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            double[] arr1 = { 1, 2, 3, 4 };
            double[] arr2 = { 3, 4, 5, 6 };
            string[] expected = {"4"+"+"+"6*x^1"+"+"+"8*x^2"+"+"+"10*x^3"};
            Polynomial actual1 = new Polynomial(arr1,3);
            Polynomial actual2 = new Polynomial(arr2, 3);
            Polynomial actual = actual1 + actual2;
            Assert.AreEqual(expected,actual);
        }
    }
}
