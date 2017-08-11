using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask3_1Test
    {
        [TestMethod]
        public void Test0_0()
        {
            int res = Cycles.Task3_1(0);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEx_m1()
        {
            int res = Cycles.Task3_1(-1);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test5_25()
        {
            int res = Cycles.Task3_1(25);
            Assert.AreEqual(5, res);
        }
        [TestMethod]
        public void Test6_40()
        {
            int res = Cycles.Task3_1(40);
            Assert.AreEqual(6, res);
        }
    }
}
