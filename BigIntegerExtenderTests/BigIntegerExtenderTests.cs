﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Numerics;

namespace BigIntegerExtenderTests
{
    [TestClass]
    public class BigIntegerExtenderTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArithmeticException))]
        public void TestSqrt_WhenValueIsNegative_ShouldThrowArithmeticException()
        {
            BigInteger.MinusOne.Sqrt();
        }

        [TestMethod]
        public void TestSqrt_WhenValueIsZero()
        {
            Assert.AreEqual(BigInteger.Zero, BigInteger.Zero.Sqrt());
        }

        [TestMethod]
        public void TestSqrt_WhenValueIsOne()
        {
            Assert.AreEqual(BigInteger.One, BigInteger.One.Sqrt());
        }

        [TestMethod]
        public void TestSqrt_WhenValueIsTwo()
        {
            Assert.AreEqual(BigInteger.One, ((BigInteger)2).Sqrt());
        }

        [TestMethod]
        public void TestSqrt_WhenIsPerfect()
        {
            BigInteger value = 9;
            Assert.AreEqual(value, BigInteger.Pow(value.Sqrt(), 2));
        }

        [TestMethod]
        public void TestSqrt_WhenIsNotPerfect()
        {
            Assert.AreEqual(3, ((BigInteger)10).Sqrt());
        }
    }
}
