using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestsForHW_1
{
    [TestClass]
    public class ConditionsTests
    {
        [DataTestMethod]
        [DataRow(-1, 1, 0)]
        [DataRow(0, 2, 0)]
        [DataRow(4, 2, 8)]
        [DataRow(3, 2, 5)]
        public void DependingOnATest(int a, int b, int res)
        {
            Assert.AreEqual(res, Conditions.DependingOnA(a,b));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuarterTestEx_x0()
        {
            int res = Conditions.Quarter(0, 5);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void QuarterTestEx_y0()
        {
            int res = Conditions.Quarter(5, 0);
        }

        [DataTestMethod]
        [DataRow(-2, 2, 2)]
        [DataRow(2, -2, 4)]
        [DataRow(-2, -2, 3)]
        [DataRow(2, 2, 1)]
        public void QuarterTest(int a, int b, int res)
        {
            Assert.AreEqual(res, Conditions.Quarter(a, b));
        }

        [DataTestMethod]
        [DataRow(-2, 3, 4, 7)]
        [DataRow(2, -3, 4, 6)]
        [DataRow(2, 3, -4, 5)]
        [DataRow(0, 3, 4, 7)]
        [DataRow(2, 0, 4, 6)]
        [DataRow(2, 3, 0, 5)]
        [DataRow(-2, -3, -4 ,0)]
        [DataRow(0, 0, 0 , 0)]
        public void SumOf3Test(int a, int b, int c, int res)
        {
            Assert.AreEqual(res, Conditions.SumOf3(a, b, c));
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 3)]
        [DataRow(2, 3, 3, 21)]
        [DataRow(2, 3, 0, 8)]
        public void MaxPlus3Test(int a, int b, int c, int res)
        {
            Assert.AreEqual(res, Conditions.MaxPlus3(a, b, c));
        }
        //--
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LiteralScoreTestEx_m1()
        {
            int res = Conditions.LiteralScore(-1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void LiteralScoreTestEx_101()
        {
            int res = Conditions.LiteralScore(101);
        }
        [DataTestMethod]
        [DataRow(10, 'F')]
        [DataRow(19, 'F')]
        [DataRow(20, 'E')]
        [DataRow(30, 'E')]
        [DataRow(39, 'E')]
        [DataRow(40, 'D')]
        [DataRow(50, 'D')]
        [DataRow(59, 'D')]
        [DataRow(60, 'C')]
        [DataRow(67, 'C')]
        [DataRow(74, 'C')]
        [DataRow(75, 'B')]
        [DataRow(83, 'B')]
        [DataRow(89, 'B')]
        [DataRow(90, 'A')]
        [DataRow(95, 'A')]
        [DataRow(100, 'A')]
        public void LiteralScoreTest(int a, char res)
        {
            Assert.AreEqual(res, Conditions.LiteralScore(a));
        }
    }
}
