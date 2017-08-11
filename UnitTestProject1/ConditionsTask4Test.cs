using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ConditionsTask4Test
    {
        [TestMethod]
        public void Test3_000()
        {
            int res = Conditions.Task4(0, 0, 0);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void Test18_c3()
        {
            int res = Conditions.Task4(2, 3, 3);
            Assert.AreEqual(21, res);
        }
        [TestMethod]
        public void Test8_c0()
        {
            int res = Conditions.Task4(2, 3, 0);
            Assert.AreEqual(8, res);
        }
    }
}
