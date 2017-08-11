using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask4Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.Task4(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.Task4(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test0_1el()
        {
            int[] arr = { 2 };
            int res = Arrays.Task4(arr);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test0_2el()
        {
            int[] arr = { 12, 3 };
            int res = Arrays.Task4(arr);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test4_8el()
        {
            int[] arr = { 2, 1, 0, -10, 80, -15, 80, -15 };
            int res = Arrays.Task4(arr);
            Assert.AreEqual(4, res);
        }
    }
}
