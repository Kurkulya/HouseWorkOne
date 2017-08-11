using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FunctionsTask1Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx_0()
        {
           string res = Functions.Task1(0);
            Assert.AreEqual("", res);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestEx_8()
        {
            string res = Functions.Task1(8);
            Assert.AreEqual("", res);
        }
        [TestMethod]
        public void TestM_1()
        {
            string res = Functions.Task1(1);
            Assert.AreEqual("Monday", res);
        }
        [TestMethod]
        public void TestT_2()
        {
            string res = Functions.Task1(2);
            Assert.AreEqual("Tuesday", res);
        }
        [TestMethod]
        public void TestW_3()
        {
            string res = Functions.Task1(3);
            Assert.AreEqual("Wednesday", res);
        }
        [TestMethod]
        public void TestT_4()
        {
            string res = Functions.Task1(4);
            Assert.AreEqual("Thursday", res);
        }
        [TestMethod]
        public void TestF_5()
        {
            string res = Functions.Task1(5);
            Assert.AreEqual("Friday", res);
        }
        [TestMethod]
        public void TestS_6()
        {
            string res = Functions.Task1(6);
            Assert.AreEqual("Saturday", res);
        }
        [TestMethod]
        public void TestS_7()
        {
            string res = Functions.Task1(7);
            Assert.AreEqual("Sunday", res);
        }
    }
}
