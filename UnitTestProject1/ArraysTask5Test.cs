using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask5Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.Task5(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.Task5(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEx_1el()
        {
            int[] arr = { 2 };
            int res = Arrays.Task5(arr);
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test3_2el()
        {
            int[] arr = { 12, 3 };
            int res = Arrays.Task5(arr);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestM19_8el()
        {
            int[] arr = { 2, 1, 0, -10, 80, -15, 9, 5 };
            int res = Arrays.Task5(arr);
            Assert.AreEqual(-19, res);
        }
    }
}
