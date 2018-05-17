using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankAccount;

namespace BankAccountTest
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestWhatistheSumMethod()
        {
            BankAccountClass account1 = new BankAccountClass(1, "Osipov Oleg", 200000, 0, "Silver");
            decimal actual = account1.WhatistheSum(account1);
            decimal expected = 200000;
            Assert.AreEqual(expected, actual);
         }
       
    }
}
