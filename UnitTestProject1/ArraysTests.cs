using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForHW_1
{
    [TestClass]
    public class ArraysTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MinTestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.Min(arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void MinTestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.Min(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { 2 }, 2)]
        [DataRow(new int[] { 12, 3 }, 3)]
        [DataRow(new int[] { 2,1,0,-10,80,-15,9,-15 }, -15)]
        public void MinTest(int[] arr, int res)
        {
            Assert.AreEqual(res, Arrays.Min(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MaxTestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.Max(arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void MaxTestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.Max(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { 2 }, 2)]
        [DataRow(new int[] { 12, 3 }, 12)]
        [DataRow(new int[] { 2, 1, 0, -10, 80, -15, 9, -15 }, 80)]
        public void MaxTest(int[] arr, int res)
        {
            Assert.AreEqual(res, Arrays.Max(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IndexOfMinTestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.IndexOfMin(arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOfMinTestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.IndexOfMin(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { 2 }, 0)]
        [DataRow(new int[] { 12, 3 }, 1)]
        [DataRow(new int[] { 2, 1, 0, -10, 80, -15, 9, -15 }, 5)]
        public void IndexOfMinTest(int[] arr, int res)
        {
            Assert.AreEqual(res, Arrays.IndexOfMin(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void IndexOfMaxTestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.IndexOfMax(arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOfMaxTestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.IndexOfMax(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { 2 }, 0)]
        [DataRow(new int[] { 12, 3 }, 0)]
        [DataRow(new int[] { 2, 1, 0, -10, 80, -15, 9, -15 }, 4)]
        public void IndexOfMaxTest(int[] arr, int res)
        {
            Assert.AreEqual(res, Arrays.IndexOfMax(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SumOfOddsIndexesElTestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.SumOfOddsIndexesEl(arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SumOfOddsIndexesElTestEx_Empty()
        {
            int[] arr = new int[0];
            int res = Arrays.SumOfOddsIndexesEl(arr);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void SumOfOddsIndexesElTestEx_1El()
        {
            int[] arr = { 1 };
            int res = Arrays.SumOfOddsIndexesEl(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { 12, 3 }, 3)]
        [DataRow(new int[] { 2, 1, 0, -10, 80, -15, 9, 5 }, -19)]
        public void SumOfOddsIndexesElTest(int[] arr, int res)
        {
            Assert.AreEqual(res, Arrays.SumOfOddsIndexesEl(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ReverseTestEx_Null()
        {
            int[] arr = null;
            Arrays.Reverse(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2})]
        [DataRow(new int[] { 12, 3 }, new int[] {3,12 })]
        [DataRow(new int[] { 2, 1, 0, -10, 80, -15, 9, 5 }, new int[] { 5,9,-15,80,-10,0,1,2})]
        public void ReverseTest(int[] arr, int[] res)
        {
            Arrays.Reverse(arr);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void CountOfOddsElTestEx_Null()
        {
            int[] arr = null;
            int res = Arrays.CountOfOddsEl(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, 0)]
        [DataRow(new int[] { 3 }, 1)]
        [DataRow(new int[] { 12, 4 }, 0)]
        [DataRow(new int[] { 2, 1, 0, -10, 80, -15, 9, -15 }, 4)]
        public void CountOfOddsElTest(int[] arr, int res)
        {
            Assert.AreEqual(res, Arrays.CountOfOddsEl(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SwapHalfesEx_Null()
        {
            int[] arr = null;
            Arrays.SwapHalfes(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, 5 }, new int[] { 80, -15, 9, 5, 2, 1, 0})]
        public void SwapHalfesTest(int[] arr, int[] res)
        {
            Arrays.SwapHalfes(arr);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BubbleSortEx_Null()
        {
            int[] arr = null;
            Arrays.BubbleSort(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80})]
        public void BubbleSortTest(int[] arr, int[] res)
        {
            Arrays.BubbleSort(arr);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void SelectSortEx_Null()
        {
            int[] arr = null;
            Arrays.SelectSort(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80 })]
        public void SelectSortTest(int[] arr, int[] res)
        {
            Arrays.SelectSort(arr);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void InsertSortEx_Null()
        {
            int[] arr = null;
            Arrays.InsertSort(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80 })]
        public void InsertSortTest(int[] arr, int[] res)
        {
            Arrays.InsertSort(arr);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void QuickSortEx_Null()
        {
            int[] arr = null;
            Arrays.QuickSort(arr,0,arr.Length-1);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void QuickSortTestEx_sm1()
        {
            int[] arr = { 12, 3 };
            Arrays.QuickSort(arr, -1, 1);
        }
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void QuickSortTestEx_e9()
        {
            int[] arr = { 12, 3 };
            Arrays.QuickSort(arr, 0, 9);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80 })]
        public void QuickSortTest(int[] arr, int[] res)
        {
            Arrays.QuickSort(arr,0,arr.Length-1);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSortEx_Null()
        {
            int[] arr = null;
            Arrays.MergeSort(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80 })]
        public void MergeSortTest(int[] arr, int[] res)
        {
            CollectionAssert.AreEqual(res, Arrays.MergeSort(arr));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ShellSortEx_Null()
        {
            int[] arr = null;
            Arrays.ShellSort(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80 })]
        public void ShellSortTest(int[] arr, int[] res)
        {
            Arrays.ShellSort(arr);
            CollectionAssert.AreEqual(res, arr);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void HeapSortEx_Null()
        {
            int[] arr = null;
            Arrays.HeapSort(arr);
        }
        [DataTestMethod]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2 }, new int[] { 2 })]
        [DataRow(new int[] { 12, 3 }, new int[] { 3, 12 })]
        [DataRow(new int[] { 2, 1, 0, 80, -15, 9, -15 }, new int[] { -15, -15, 0, 1, 2, 9, 80 })]
        public void HeapSortTest(int[] arr, int[] res)
        {
            Arrays.HeapSort(arr);
            CollectionAssert.AreEqual(res, arr);
        }
    }
}
