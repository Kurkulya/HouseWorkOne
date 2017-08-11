using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask1Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.Task1(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.Task1(arr);
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test2_1el()
        {
            int[] arr = { 2 };
            int res = Arrays.Task1(arr);
            Assert.AreEqual(2, res);
        }
        [TestMethod]
        public void Test3_2el()
        {
            int[] arr = { 12,3 };
            int res = Arrays.Task1(arr);
            Assert.AreEqual(3, res);
        }
        [TestMethod]
        public void TestM15_8el()
        {
            int[] arr = { 2 ,1,0,-10,80,-15,9,-15};
            int res = Arrays.Task1(arr);
            Assert.AreEqual(-15, res);
        }
    }
}
