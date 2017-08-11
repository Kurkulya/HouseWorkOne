using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask6Test
    {
        [TestMethod]
        public void Test0_0()
        {
            int res = Cycles.Task6(0);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test321_m123()
        {
            int res = Cycles.Task6(-123);
            Assert.AreEqual(321, res);
        }
        [TestMethod]
        public void Test5_5()
        {
            int res = Cycles.Task6(5);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void Test402_2040()
        {
            int res = Cycles.Task6(2040);
            Assert.AreEqual(402, res);
        }
        [TestMethod]
        public void Test803021_120308()
        {
            int res = Cycles.Task6(120308);
            Assert.AreEqual(803021, res);
        }
    }
}
