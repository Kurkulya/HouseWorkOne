using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask7Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.Task7(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test0_Empty()
        {
            int[] arr = { };
            int res = Arrays.Task7(arr);
            Assert.AreEqual(0, res);
        }
        [TestMethod]       
        public void Test1_1el()
        {
            int[] arr = { 3 };
            int res = Arrays.Task7(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test0_2el()
        {
            int[] arr = { 12, 4 };
            int res = Arrays.Task7(arr);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test3_8el()
        {
            int[] arr = { 2, 1, 0, -10, 80, -15, 9, 5 };
            int res = Arrays.Task7(arr);
            Assert.AreEqual(4, res);
        }
    }
}
