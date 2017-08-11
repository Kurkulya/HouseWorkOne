using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask10_2Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            Assert.AreEqual(1, Arrays.Task10_2(arr));
        }
        [TestMethod]
        public void Test_Empty()
        {
            int[] arr = new int[0];
            CollectionAssert.AreEqual(new int[] { }, Arrays.Task10_2(arr));
        }
        [TestMethod]
        public void Test_1el()
        {
            int[] arr = { 2 };      
            CollectionAssert.AreEqual(new int[] { 2 }, Arrays.Task10_2(arr));
        }
        [TestMethod]
        public void Test_2el()
        {
            int[] arr = { 12, 3 };
            CollectionAssert.AreEqual(new int[] { 3, 12 }, Arrays.Task10_2(arr));
        }
        [TestMethod]
        public void Test_5el()
        {
            int[] arr = { 2, 1, 0, -10, 80 };
            CollectionAssert.AreEqual(new int[] { -10, 0, 1, 2, 80 }, Arrays.Task10_2(arr));
        }
    }
}
