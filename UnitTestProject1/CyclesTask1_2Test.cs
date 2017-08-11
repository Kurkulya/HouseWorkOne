using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class CyclesTask1_2Test
    {
        [TestMethod]
        public void Test49()
        {
            int res = Cycles.Task1_2();
            Assert.AreEqual(49, res);
        }       
    }
}
