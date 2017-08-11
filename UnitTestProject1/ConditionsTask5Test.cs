using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class ConditionsTask5Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx_m1()
        {
            char res = Conditions.Task5(-1);
            Assert.AreEqual('F', res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx_101()
        {
            char res = Conditions.Task5(101);
            Assert.AreEqual('F', res);
        }
        [TestMethod]
        public void TestF_0()
        {
            char res = Conditions.Task5(0);
            Assert.AreEqual('F', res);
        }
        [TestMethod]
        public void TestF_10()
        {
            char res = Conditions.Task5(10);
            Assert.AreEqual('F', res);
        }
        [TestMethod]
        public void TestF_19()
        {
            char res = Conditions.Task5(19);
            Assert.AreEqual('F', res);
        }
        [TestMethod]
        public void TestE_20()
        {
            char res = Conditions.Task5(20);
            Assert.AreEqual('E', res);
        }
        [TestMethod]
        public void TestE_30()
        {
            char res = Conditions.Task5(30);
            Assert.AreEqual('E', res);
        }
        [TestMethod]
        public void TestE_39()
        {
            char res = Conditions.Task5(39);
            Assert.AreEqual('E', res);
        }
        [TestMethod]
        public void TestD_40()
        {
            char res = Conditions.Task5(40);
            Assert.AreEqual('D', res);
        }
        [TestMethod]
        public void TestD_50()
        {
            char res = Conditions.Task5(50);
            Assert.AreEqual('D', res);
        }
        [TestMethod]
        public void TestD_59()
        {
            char res = Conditions.Task5(59);
            Assert.AreEqual('D', res);
        }
        [TestMethod]
        public void TestC_60()
        {
            char res = Conditions.Task5(60);
            Assert.AreEqual('C', res);
        }
        [TestMethod]
        public void TestС_67()
        {
            char res = Conditions.Task5(67);
            Assert.AreEqual('C', res);
        }
        [TestMethod]
        public void TestС_74()
        {
            char res = Conditions.Task5(74);
            Assert.AreEqual('C', res);
        }
        [TestMethod]
        public void TestB_75()
        {
            char res = Conditions.Task5(75);
            Assert.AreEqual('B', res);
        }
        [TestMethod]
        public void TestB_83()
        {
            char res = Conditions.Task5(83);
            Assert.AreEqual('B', res);
        }
        [TestMethod]
        public void TestB_89()
        {
            char res = Conditions.Task5(89);
            Assert.AreEqual('B', res);
        }
        [TestMethod]
        public void TestA_90()
        {
            char res = Conditions.Task5(90);
            Assert.AreEqual('A', res);
        }
        [TestMethod]
        public void TestA_95()
        {
            char res = Conditions.Task5(95);
            Assert.AreEqual('A', res);
        }
        [TestMethod]
        public void TestA_100()
        {
            char res = Conditions.Task5(100);
            Assert.AreEqual('A', res);
        }
    }
}
