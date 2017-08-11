using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ConditionsTask2Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEx_x0()
        {
            int res = Conditions.Task2(0, 5);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEx_y0()
        {
            int res = Conditions.Task2(5, 0);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void Test2_xm2y2()
        {
            int res = Conditions.Task2(-2, 2);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void Test4_x2ym2()
        {
            int res = Conditions.Task2(2, -2);
            Assert.AreEqual(4, res);
        }
        [TestMethod]
        public void Test3_xm2ym2()
        {
            int res = Conditions.Task2(-2, -2);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void Test1_x2y2()
        {
            int res = Conditions.Task2(2, 2);
            Assert.AreEqual(1, res);
        }
    }
}
