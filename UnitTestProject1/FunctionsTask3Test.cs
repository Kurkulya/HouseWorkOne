using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FunctionsTask3Test
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestEx_m1()
        {
            long res = Functions.Task3("whatever");
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void TestN_0()
        {
            long res = Functions.Task3("ноль");
            Assert.AreEqual(0, res);
        }
        [TestMethod]
        public void Test_1()
        {
            long res = Functions.Task3("один");
            Assert.AreEqual(1, res);
        }
        [TestMethod]
        public void Test_2()
        {
            long res = Functions.Task3("два");
            Assert.AreEqual(2, res);
            
        }
        [TestMethod]
        public void Test_3()
        {
            long res = Functions.Task3("три");
            Assert.AreEqual(3, res);
            
        }
        [TestMethod]
        public void Test_4()
        {
            long res = Functions.Task3("четыре");
            Assert.AreEqual(4, res);
            
        }
        [TestMethod]
        public void Test_5()
        {
            long res = Functions.Task3("пять");
            Assert.AreEqual(5, res);
            
        }
        [TestMethod]
        public void Test_6()
        {
            long res = Functions.Task3("шесть");
            Assert.AreEqual(6, res);
            
        }
        [TestMethod]
        public void Test_7()
        {
            long res = Functions.Task3("семь");
            Assert.AreEqual(7, res);
            
        }
        [TestMethod]
        public void Test_8()
        {
            long res = Functions.Task3("восемь");
            Assert.AreEqual(8, res);
        }
        [TestMethod]
        public void Test_9()
        {
            long res = Functions.Task3("девять");
            Assert.AreEqual(9, res);
        }
        [TestMethod]
        public void Test_10()
        {
            long res = Functions.Task3("десять");
            Assert.AreEqual(10, res);
        }
        [TestMethod]
        public void Test_11()
        {
            long res = Functions.Task3("одиннадцать");
            Assert.AreEqual(11, res);
        }
        [TestMethod]
        public void Test_12()
        {
            long res = Functions.Task3("двенадцать");
            Assert.AreEqual(12, res);
        }
        [TestMethod]
        public void Test_13()
        {
            long res = Functions.Task3("тринадцать");
            Assert.AreEqual(13, res);
        }
        [TestMethod]
        public void Test_14()
        {
            long res = Functions.Task3("четырнадцать");
            Assert.AreEqual(14, res);
        }
        [TestMethod]
        public void Test_15()
        {
            long res = Functions.Task3("пятнадцать");
            Assert.AreEqual(15, res);
        }
        [TestMethod]
        public void Test_16()
        {
            long res = Functions.Task3("шестнадцать");
            Assert.AreEqual(16, res);
        }
        [TestMethod]
        public void Test_17()
        {
            long res = Functions.Task3("семнадцать");
            Assert.AreEqual(17, res);
        }
        [TestMethod]
        public void Test_18()
        {
            long res = Functions.Task3("восемьнадцать");
            Assert.AreEqual(18, res);
        }
        [TestMethod]
        public void Test_19()
        {
            long res = Functions.Task3("девятьнадцать");
            Assert.AreEqual(19, res);
        }
        [TestMethod]
        public void Test_20()
        {
            long res = Functions.Task3("двадцать");
            Assert.AreEqual(20, res);
        }
        [TestMethod]
        public void Test_30()
        {
            long res = Functions.Task3("тридцать");
            Assert.AreEqual(30, res);
        }
        [TestMethod]
        public void Test_40()
        {
            long res = Functions.Task3("сорок");
            Assert.AreEqual(40, res);
        }
        [TestMethod]
        public void Test_50()
        {
            long res = Functions.Task3("пятьдесят");
            Assert.AreEqual(50, res);
        }
        [TestMethod]
        public void Test_60()
        {
            long res = Functions.Task3("шестьдесят");
            Assert.AreEqual(60, res);
        }
        [TestMethod]
        public void Test_70()
        {
            long res = Functions.Task3("семьдесят");
            Assert.AreEqual(70, res);
        }
        [TestMethod]
        public void Test_80()
        {
            long res = Functions.Task3("восемьдесят");
            Assert.AreEqual(80, res);
        }
        [TestMethod]
        public void Test_90()
        {
            long res = Functions.Task3("девяносто");
            Assert.AreEqual(90, res);
        }
        [TestMethod]
        public void Test_100()
        {
            long res = Functions.Task3("сто");
            Assert.AreEqual(100, res);
        }
        [TestMethod]
        public void Test_200()
        {
            long res = Functions.Task3("двести");
            Assert.AreEqual(200, res);
        }
        [TestMethod]
        public void Test_300()
        {
            long res = Functions.Task3("триста");
            Assert.AreEqual(300, res);
        }
        [TestMethod]
        public void Test_400()
        {
            long res = Functions.Task3("четыреста");
            Assert.AreEqual(400, res);
        }
        [TestMethod]
        public void Test_500()
        {
            long res = Functions.Task3("пятьсот");
            Assert.AreEqual(500, res);
        }
        [TestMethod]
        public void Test_600()
        {
            long res = Functions.Task3("шестьсот");
            Assert.AreEqual(600, res);
        }
        [TestMethod]
        public void Test_700()
        {
            long res = Functions.Task3("семьсот");
            Assert.AreEqual(700, res);
        }
        [TestMethod]
        public void Test_800()
        {
            long res = Functions.Task3("восемьсот");
            Assert.AreEqual(800, res);
        }
        [TestMethod]
        public void Test_900()
        {
            long res = Functions.Task3("девятьсот");
            Assert.AreEqual(900, res);
        }
        [TestMethod]
        public void Test_1000()
        {
            long res = Functions.Task3("одна тысяча");
            Assert.AreEqual(1000, res);
        }
        [TestMethod]
        public void Test_2000()
        {
            long res = Functions.Task3("две тысячи");
            Assert.AreEqual(2000, res);
        }
        [TestMethod]
        public void Test_5000()
        {
            long res = Functions.Task3("пять тысяч");
            Assert.AreEqual(5000, res);
        }
        [TestMethod]
        public void Test_1000000()
        {
            long res = Functions.Task3("один миллион");
            Assert.AreEqual(1000000, res);
        }
        [TestMethod]
        public void Test_2000000()
        {
            long res = Functions.Task3("два миллиона");
            Assert.AreEqual(2000000, res);
        }
        [TestMethod]
        public void Test_5000000()
        {
            long res = Functions.Task3("пять миллионов");
            Assert.AreEqual(5000000, res);
        }
        [TestMethod]
        public void Test_1000000000()
        {
            long res = Functions.Task3("один миллиард");
            Assert.AreEqual(1000000000, res);
        }
        [TestMethod]
        public void Test_2000000000()
        {
            long res = Functions.Task3("два миллиарда");
            Assert.AreEqual(2000000000, res);
        }
        [TestMethod]
        public void Test_5000000000()
        {
            long res = Functions.Task3("пять миллиардов");
            Assert.AreEqual(5000000000, res);
        }
        [TestMethod]
        public void Test_9876543210()
        {
            long res = Functions.Task3("девять миллиардов восемьсот семьдесят шесть миллионов пятьсот сорок три тысячи двести десять");
            Assert.AreEqual(9876543210, res);
        }
        [TestMethod]
        public void Test_1234567890()
        {
            long res = Functions.Task3("один миллиард двести тридцать четыре миллиона пятьсот шестьдесят семь тысяч восемьсот девяносто");
            Assert.AreEqual(1234567890, res);
        }
    }
}
