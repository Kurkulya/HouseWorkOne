using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ConditionsTask3Test
    {
        [TestMethod]
        public void Test7_am2()
        {
            int res = Conditions.Task3(-2, 3, 4);
            Assert.AreEqual(7, res);
        }
        [TestMethod]
        public void Test6_bm3()
        {
            int res = Conditions.Task3(2, -3, 4);
            Assert.AreEqual(6, res);
        }
        [TestMethod]
        public void Test5_cm4()
        {
            int res = Conditions.Task3(2, 3, -4);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void Test7_a0()
        {
            int res = Conditions.Task3(0, 3, 4);
            Assert.AreEqual(7, res);
        }
        [TestMethod]
        public void Test6_b0()
        {
            int res = Conditions.Task3(2, 0, 4);
            Assert.AreEqual(6, res);
        }
        [TestMethod]
        public void Test5_c0()
        {
            int res = Conditions.Task3(2, 3, 0);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void Test0_m2m3m4()
        {
            int res = Conditions.Task3(-2, -3, -4);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test0_000()
        {
            int res = Conditions.Task3(0, 0, 0);
            Assert.AreEqual(0, res);
        }
    }
}
