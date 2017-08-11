using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask1_1Test
    {
        [TestMethod]
        public void Test2450()
        {
            int res = Cycles.Task1_1();
            Assert.AreEqual(2450, res);
        }       
    }
}
