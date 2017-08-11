using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask10_1Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            Arrays.Task10_1(arr,0,0);
            Assert.AreEqual(1, arr);
        }
       
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEx_sm1()
        {
            int[] arr = { 12, 3 };
            Arrays.Task10_1(arr, -1, 1);
            Assert.AreEqual(1, arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestEx_e9()
        {
            int[] arr = { 12, 3 };
            Arrays.Task10_1(arr, 0, 9);
            Assert.AreEqual(1, arr);
        }
        [TestMethod]
        public void Test_Empty()
        {
            int[] arr = new int[0];
            Arrays.Task10_1(arr,0,arr.Length-1);
            CollectionAssert.AreEqual(new int[] { }, arr);
        }
        [TestMethod]
        public void Test_1el()
        {
            int[] arr = { 2 };
            Arrays.Task10_1(arr, 0, arr.Length-1);
            CollectionAssert.AreEqual(new int[] { 2 }, arr);
        }
        [TestMethod]
        public void Test_2el()
        {
            int[] arr = { 12, 3 };
            Arrays.Task10_1(arr, 0, arr.Length-1);
            CollectionAssert.AreEqual(new int[] { 3, 12 }, arr);
        }
        [TestMethod]
        public void Test_5el()
        {
            int[] arr = { 2, 1, 0, -10, 80 };
            Arrays.Task10_1(arr, 0, arr.Length-1);
            CollectionAssert.AreEqual(new int[] { -10, 0, 1, 2, 80 }, arr);
        }
    }
}
