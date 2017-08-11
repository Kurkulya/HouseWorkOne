using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FunctionsTask2Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEx_m1()
        {
            string res = Functions.Task2(-1);
            Assert.AreEqual("", res);
        }
        [TestMethod]
        public void TestN_0()
        {
            string res = Functions.Task2(0);
            Assert.AreEqual("ноль", res);
        }
        [TestMethod]
        public void Test_1()
        {
            string res = Functions.Task2(1);
            Assert.AreEqual("один", res);
        }
        [TestMethod]
        public void Test_2()
        {
            string res = Functions.Task2(2);
            Assert.AreEqual("два", res);
        }
        [TestMethod]
        public void Test_3()
        {
            string res = Functions.Task2(3);
            Assert.AreEqual("три", res);
        }
        [TestMethod]
        public void Test_4()
        {
            string res = Functions.Task2(4);
            Assert.AreEqual("четыре", res);
        }
        [TestMethod]
        public void Test_5()
        {
            string res = Functions.Task2(5);
            Assert.AreEqual("пять", res);
        }
        [TestMethod]
        public void Test_6()
        {
            string res = Functions.Task2(6);
            Assert.AreEqual("шесть", res);
        }
        [TestMethod]
        public void Test_7()
        {
            string res = Functions.Task2(7);
            Assert.AreEqual("семь", res);
        }
        [TestMethod]
        public void Test_8()
        {
            string res = Functions.Task2(8);
            Assert.AreEqual("восемь", res);
        }
        [TestMethod]
        public void Test_9()
        {
            string res = Functions.Task2(9);
            Assert.AreEqual("девять", res);
        }
        [TestMethod]
        public void Test_10()
        {
            string res = Functions.Task2(10);
            Assert.AreEqual("десять", res);
        }
        [TestMethod]
        public void Test_11()
        {
            string res = Functions.Task2(11);
            Assert.AreEqual("одиннадцать", res);
        }
        [TestMethod]
        public void Test_12()
        {
            string res = Functions.Task2(12);
            Assert.AreEqual("двенадцать", res);
        }
        [TestMethod]
        public void Test_13()
        {
            string res = Functions.Task2(13);
            Assert.AreEqual("тринадцать", res);
        }
        [TestMethod]
        public void Test_14()
        {
            string res = Functions.Task2(14);
            Assert.AreEqual("четырнадцать", res);
        }
        [TestMethod]
        public void Test_15()
        {
            string res = Functions.Task2(15);
            Assert.AreEqual("пятнадцать", res);
        }
        [TestMethod]
        public void Test_16()
        {
            string res = Functions.Task2(16);
            Assert.AreEqual("шестнадцать", res);
        }
        [TestMethod]
        public void Test_17()
        {
            string res = Functions.Task2(17);
            Assert.AreEqual("семнадцать", res);
        }
        [TestMethod]
        public void Test_18()
        {
            string res = Functions.Task2(18);
            Assert.AreEqual("восемьнадцать", res);
        }
        [TestMethod]
        public void Test_19()
        {
            string res = Functions.Task2(19);
            Assert.AreEqual("девятьнадцать", res);
        }
        [TestMethod]
        public void Test_20()
        {
            string res = Functions.Task2(20);
            Assert.AreEqual("двадцать", res);
        }
        [TestMethod]
        public void Test_30()
        {
            string res = Functions.Task2(30);
            Assert.AreEqual("тридцать", res);
        }
        [TestMethod]
        public void Test_40()
        {
            string res = Functions.Task2(40);
            Assert.AreEqual("сорок", res);
        }
        [TestMethod]
        public void Test_50()
        {
            string res = Functions.Task2(50);
            Assert.AreEqual("пятьдесят", res);
        }
        [TestMethod]
        public void Test_60()
        {
            string res = Functions.Task2(60);
            Assert.AreEqual("шестьдесят", res);
        }
        [TestMethod]
        public void Test_70()
        {
            string res = Functions.Task2(70);
            Assert.AreEqual("семьдесят", res);
        }
        [TestMethod]
        public void Test_80()
        {
            string res = Functions.Task2(80);
            Assert.AreEqual("восемьдесят", res);
        }
        [TestMethod]
        public void Test_90()
        {
            string res = Functions.Task2(90);
            Assert.AreEqual("девяносто", res);
        }
        [TestMethod]
        public void Test_100()
        {
            string res = Functions.Task2(100);
            Assert.AreEqual("сто", res);
        }
        [TestMethod]
        public void Test_200()
        {
            string res = Functions.Task2(200);
            Assert.AreEqual("двести", res);
        }
        [TestMethod]
        public void Test_300()
        {
            string res = Functions.Task2(300);
            Assert.AreEqual("триста", res);
        }
        [TestMethod]
        public void Test_400()
        {
            string res = Functions.Task2(400);
            Assert.AreEqual("четыреста", res);
        }
        [TestMethod]
        public void Test_500()
        {
            string res = Functions.Task2(500);
            Assert.AreEqual("пятьсот", res);
        }
        [TestMethod]
        public void Test_600()
        {
            string res = Functions.Task2(600);
            Assert.AreEqual("шестьсот", res);
        }
        [TestMethod]
        public void Test_700()
        {
            string res = Functions.Task2(700);
            Assert.AreEqual("семьсот", res);
        }
        [TestMethod]
        public void Test_800()
        {
            string res = Functions.Task2(800);
            Assert.AreEqual("восемьсот", res);
        }
        [TestMethod]
        public void Test_900()
        {
            string res = Functions.Task2(900);
            Assert.AreEqual("девятьсот", res);
        }
        [TestMethod]
        public void Test_1000()
        {
            string res = Functions.Task2(1000);
            Assert.AreEqual("одна тысяча", res);
        }
        [TestMethod]
        public void Test_2000()
        {
            string res = Functions.Task2(2000);
            Assert.AreEqual("две тысячи", res);
        }
        [TestMethod]
        public void Test_5000()
        {
            string res = Functions.Task2(5000);
            Assert.AreEqual("пять тысяч", res);
        }
        [TestMethod]
        public void Test_1000000()
        {
            string res = Functions.Task2(1000000);
            Assert.AreEqual("один миллион", res);
        }
        [TestMethod]
        public void Test_2000000()
        {
            string res = Functions.Task2(2000000);
            Assert.AreEqual("два миллиона", res);
        }
        [TestMethod]
        public void Test_5000000()
        {
            string res = Functions.Task2(5000000);
            Assert.AreEqual("пять миллионов", res);
        }
        [TestMethod]
        public void Test_1000000000()
        {
            string res = Functions.Task2(1000000000);
            Assert.AreEqual("один миллиард", res);
        }
        [TestMethod]
        public void Test_2000000000()
        {
            string res = Functions.Task2(2000000000);
            Assert.AreEqual("два миллиарда", res);
        }
        [TestMethod]
        public void Test_5000000000()
        {
            string res = Functions.Task2(5000000000);
            Assert.AreEqual("пять миллиардов", res);
        }
        [TestMethod]
        public void Test_9876543210()
        {
            string res = Functions.Task2(9876543210);
            Assert.AreEqual("девять миллиардов восемьсот семьдесят шесть миллионов пятьсот сорок три тысячи двести десять", res);
        }
        [TestMethod]
        public void Test_1234567890()
        {
            string res = Functions.Task2(1234567890);
            Assert.AreEqual("один миллиард двести тридцать четыре миллиона пятьсот шестьдесят семь тысяч восемьсот девяносто", res);
        }
    }
}
