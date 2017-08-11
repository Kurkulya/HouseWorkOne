﻿using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ArraysTask10_4Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestEx_Null()
        {
            int[] arr = null;
            Arrays.Task10_4(arr);
            Assert.AreEqual(1, arr);
        }
        [TestMethod]
        public void Test_Empty()
        {
            int[] arr = new int[0];
            Arrays.Task10_4(arr);
            CollectionAssert.AreEqual(new int[] { }, arr);
        }
        [TestMethod]
        public void Test_1el()
        {
            int[] arr = { 2 };
            Arrays.Task10_4(arr);
            CollectionAssert.AreEqual(new int[] { 2 }, arr);
        }
        [TestMethod]
        public void Test_2el()
        {
            int[] arr = { 12, 3 };
            Arrays.Task10_4(arr);
            CollectionAssert.AreEqual(new int[] { 3, 12 }, arr);
        }
        [TestMethod]
        public void Test_5el()
        {
            int[] arr = { 2, 1, 0, -10, 80 };
            Arrays.Task10_4(arr);
            CollectionAssert.AreEqual(new int[] { -10, 0, 1, 2, 80 }, arr);
        }
    }
}