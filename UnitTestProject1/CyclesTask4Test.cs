using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask4Test
    {
        [TestMethod]
        public void Test1_0()
        {
            long res = Cycles.Task4(0);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEx_m1()
        {
            long res = Cycles.Task4(-1);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test2_2()
        {
            long res = Cycles.Task4(2);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void Test24_4()
        {
            long res = Cycles.Task4(4);
            Assert.AreEqual(24, res);
        }
    }
}
