using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForHW_1
{
    [TestClass]
    public class LoopsTests
    {
        [TestMethod]
        public void EvensSumOf100Test()
        {
            int res = Loops.EvensSumOf100();
            Assert.AreEqual(2450, res);
        }

        [TestMethod]
        public void EvensCountOf100Test()
        {
            int res = Loops.EvensCountOf100();
            Assert.AreEqual(49, res);
        }

        [DataTestMethod]
        [DataRow(1, false)]
        [DataRow(0, false)]
        [DataRow(-1, false)]
        [DataRow(2, true)]
        [DataRow(11, true)]
        [DataRow(10, false)]
        public void IsSimpleTest(int a, bool res)
        {
            Assert.AreEqual(res, Loops.IsSimple(a));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SqrtBinaryTestEx_m1()
        {
            int res = Loops.SqrtBinary(-1);
        }
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(25, 5)]
        [DataRow(40, 6)]
        [DataRow(16, 4)]
        [DataRow(101, 10)]
        public void SqrtBinaryTest(int a, int res)
        {
            Assert.AreEqual(res,Loops.SqrtBinary(a));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SqrtOrdinaryTestEx_m1()
        {
            int res = Loops.SqrtOrdinary(-1);
        }
        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(25, 5)]
        [DataRow(40, 6)]
        public void SqrtOrdinaryTest(int a, int res)
        {
            Assert.AreEqual(res, Loops.SqrtOrdinary(a));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FactorialTestEx_m1()
        {
            long res = Loops.Factorial(-1);
        }
        [DataTestMethod]
        [DataRow(0, 1)]
        [DataRow(2, 2)]
        [DataRow(4, 24)]
        public void FactorialTest(int a, int res)
        {
            Assert.AreEqual(res, Loops.Factorial(a));
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(10, 1)]
        [DataRow(203, 5)]
        [DataRow(-1291, 13)]
        [DataRow(5, 5)]
        [DataRow(1234506, 21)]
        public void SumOfDigitsTest(int a, int res)
        {
            Assert.AreEqual(res, Loops.SumOfDigits(a));
        }

        [DataTestMethod]
        [DataRow(0, 0)]
        [DataRow(-123, 321)]
        [DataRow(5, 5)]
        [DataRow(2040, 402)]
        [DataRow(120308, 803021)]
        public void ReverseDigitsTest(int a, int res)
        {
            Assert.AreEqual(res, Loops.ReverseDigits(a));
        }
    }


}
