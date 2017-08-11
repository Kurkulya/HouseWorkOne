using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ConditionsTests
    {
        [TestMethod]
        public void Test1_am1()
        {
            int res = Conditions.Task1(-1, 2);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Tes0_a0()
        {
            int res = Conditions.Task1(0, 2);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test8_a4()
        {
            int res = Conditions.Task1(4, 2);
            Assert.AreEqual(8, res);
        }
        [TestMethod]
        public void Test5_a3()
        {
            int res = Conditions.Task1(3, 2);
            Assert.AreEqual(5, res);
        }
    }
}
