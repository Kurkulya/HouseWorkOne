using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask8Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            Arrays.Task8(arr);
            Assert.AreEqual(1, arr);
        }
        [TestMethod]
        public void Test_Empty()
        {
            int[] arr = new int[0];
            Arrays.Task8(arr);
            CollectionAssert.AreEqual(new int[] { }, arr);
        }
        [TestMethod]
        public void Test_1el()
        {
            int[] arr = { 2 };
            Arrays.Task8(arr);
            CollectionAssert.AreEqual(new int[] { 2 }, arr);
        }
        [TestMethod]
        public void Test_2el()
        {
            int[] arr = { 12, 3 };
            Arrays.Task8(arr);
            CollectionAssert.AreEqual(new int[] { 3, 12 }, arr);
        }
        [TestMethod]
        public void Test_4el()
        {
            int[] arr = { 2, 1, 0, -10};
            Arrays.Task8(arr);
            CollectionAssert.AreEqual(new int[] { 0, -10, 2, 1 }, arr);
        }
        [TestMethod]
        public void Test_5el()
        {
            int[] arr = { 2, 1, 0, -10, 80 };
            Arrays.Task8(arr);
            CollectionAssert.AreEqual(new int[] { 0, -10, 80, 2, 1 }, arr);
        }
    }
}
