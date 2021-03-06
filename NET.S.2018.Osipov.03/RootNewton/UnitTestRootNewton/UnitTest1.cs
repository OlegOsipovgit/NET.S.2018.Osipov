﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RootNewton; 

namespace UnitTestRootNewton
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double expected = 1;
            double actual = NewtonMethodClass.Newton(1, 5, 0.0001);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod2()
        {
            double expected = 2;
            double actual = NewtonMethodClass.Newton(8, 3, 0.0001);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod3()
        {
            double expected = 0.1;
            double actual = NewtonMethodClass.Newton(0.001, 3, 0.0001);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double expected = 0.45;
            double actual = NewtonMethodClass.Newton(0.04100625, 4, 0.0001);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod5()
        {
            double expected = 0.6;
            double actual = NewtonMethodClass.Newton(0.0279936, 7, 0.0001);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod6()
        {
            double expected = 0.3;
            double actual = NewtonMethodClass.Newton(0.0081, 4, 0.1);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod7()
        {
            double expected = -0.2;
            double actual = NewtonMethodClass.Newton(-0.008, 3, 0.1);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod8()
        {
            double expected = 0.545;
            double actual = NewtonMethodClass.Newton(0.004241979, 9, 0.00000001);
            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod9()
        {
            double value = 8;
            double degree = 15;
            double expected = -5;
            double accuracy = -7;
            
            double actual = NewtonMethodClass.Newton(value, degree, accuracy);

            Assert.AreEqual(expected, actual, 1);
        }
        [TestMethod]
        public void TestMethod10()
        {
            double value = 8;
            double degree = 15;
            double expected = -1;
            double accuracy = -0.6;
           
            double actual = NewtonMethodClass.Newton(value, degree, accuracy);

            Assert.AreEqual(expected, actual, 1);

        }
    }

}
