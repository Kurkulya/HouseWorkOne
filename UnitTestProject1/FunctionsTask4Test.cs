using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FunctionsTask4Test
    {
        [TestMethod]
        public void Test0_0000()
        {
            int res = Functions.Task4(0, 0, 0, 0);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test0_SamePoints()
        {
            int res = Functions.Task4(10, 10, 10, 10);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test12_SameX()
        {
            int res = Functions.Task4(-10, -2, -10, 10);
            Assert.AreEqual(12, res);
        }
        [TestMethod]
        public void Test1_simple()
        {
            int res = Functions.Task4(4, 2, 3, 1);
            Assert.AreEqual(1, res);
        }
    }
}
