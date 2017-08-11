using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask2Test
    {
        [TestMethod]
        public void TestFalse_1()
        {
            bool res = Cycles.Task2(1);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestFalse_0()
        {
            bool res = Cycles.Task2(0);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestFalse_m1()
        {
            bool res = Cycles.Task2(-1);
            Assert.AreEqual(false, res);
        }
        [TestMethod]
        public void TestTrue_2()
        {
            bool res = Cycles.Task2(2);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestTrue_11()
        {
            bool res = Cycles.Task2(11);
            Assert.AreEqual(true, res);
        }
        [TestMethod]
        public void TestFalse_10()
        {
            bool res = Cycles.Task2(10);
            Assert.AreEqual(false, res);
        }
    }
}
