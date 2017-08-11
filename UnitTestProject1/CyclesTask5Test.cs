using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask5Test
    {
        [TestMethod]
        public void Test0_0()
        {
            int res = Cycles.Task5(0);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test1_10()
        {
            int res = Cycles.Task5(10);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test5_203()
        {
            int res = Cycles.Task5(203);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void Test13_m1291()
        {
            int res = Cycles.Task5(-1291);
            Assert.AreEqual(13, res);
        }
        [TestMethod]
        public void Test5_5()
        {
            int res = Cycles.Task5(5);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void Test21_1234506()
        {
            int res = Cycles.Task5(1234506);
            Assert.AreEqual(21, res);
        }
    }
}
