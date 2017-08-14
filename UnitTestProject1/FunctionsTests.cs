using System;
using HouseWorkOne;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class FunctionsTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DayOfWeekTestEx_0()
        {
            string res = Functions.DayOfWeek(0);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DayOfWeekTestEx_8()
        {
            string res = Functions.DayOfWeek(8);
        }
        [DataTestMethod]
        [DataRow(1,"Sunday")]
        [DataRow(2, "Monday")]
        [DataRow(3, "Tuesday")]
        [DataRow(4, "Wednesday")]
        [DataRow(5, "Thursday")]
        [DataRow(6, "Friday")]
        [DataRow(7, "Saturday")]
        public void DayOfWeekTest(int a, string res)
        {
            Assert.AreEqual(res,Functions.DayOfWeek(a));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NumToStrBillionsTestEx_m1()
        {
            string res = Functions.NumToStrBillions(-1);
        }
        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(2, "two")]
        [DataRow(3, "three")]
        [DataRow(4, "four")]
        [DataRow(5, "five")]
        [DataRow(6, "six")]
        [DataRow(7, "seven")]
        [DataRow(8, "eight")]
        [DataRow(9, "nine")]
        [DataRow(10, "ten")]
        [DataRow(11, "eleven")]
        [DataRow(12, "twelve")]
        [DataRow(13, "thirteen")]
        [DataRow(14, "fourteen")]
        [DataRow(15, "fifteen")]
        [DataRow(16, "sixteen")]
        [DataRow(17, "seventeen")]
        [DataRow(18, "eighteen")]
        [DataRow(19, "nineteen")]
        [DataRow(20, "twenty")]
        [DataRow(30, "thirty")]
        [DataRow(40, "fourty")]
        [DataRow(50, "fifty")]
        [DataRow(60, "sixty")]
        [DataRow(70, "seventy")]
        [DataRow(80, "eighty")]
        [DataRow(90, "ninety")]
        [DataRow(100, "one hundred")]
        [DataRow(24, "twenty-four")]
        [DataRow(314, "three hundred fourteen")]
        [DataRow(1000, "one thousand")]
        [DataRow(1000000, "one million")]
        [DataRow(1000000000, "one billion")]
        [DataRow(9876543210, "nine billion eight hundred seventy-six million five hundred fourty-three thousand two hundred ten")]
        [DataRow(561234567890, "five hundred sixty-one billion two hundred thirty-four million five hundred sixty-seven thousand eight hundred ninety")]
        public void NumToStrBillionsTest(long num, string res)
        {
            Assert.AreEqual(res, Functions.NumToStrBillions(num));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StrToNumBillionsTestEx()
        {
            long res = Functions.StrToNumBillions("Whatever");
        }
        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(2, "two")]
        [DataRow(3, "three")]
        [DataRow(4, "four")]
        [DataRow(5, "five")]
        [DataRow(6, "six")]
        [DataRow(7, "seven")]
        [DataRow(8, "eight")]
        [DataRow(9, "nine")]
        [DataRow(10, "ten")]
        [DataRow(11, "eleven")]
        [DataRow(12, "twelve")]
        [DataRow(13, "thirteen")]
        [DataRow(14, "fourteen")]
        [DataRow(15, "fifteen")]
        [DataRow(16, "sixteen")]
        [DataRow(17, "seventeen")]
        [DataRow(18, "eighteen")]
        [DataRow(19, "nineteen")]
        [DataRow(20, "twenty")]
        [DataRow(30, "thirty")]
        [DataRow(40, "fourty")]
        [DataRow(50, "fifty")]
        [DataRow(60, "sixty")]
        [DataRow(70, "seventy")]
        [DataRow(80, "eighty")]
        [DataRow(90, "ninety")]
        [DataRow(100, "one hundred")]
        [DataRow(24, "twenty-four")]
        [DataRow(314, "three hundred fourteen")]
        [DataRow(1000, "one thousand")]
        [DataRow(1000000, "one million")]
        [DataRow(1000000000, "one billion")]
        [DataRow(9876543210, "nine billion eight hundred seventy-six million five hundred fourty-three thousand two hundred ten")]
        [DataRow(561234567890, "five hundred sixty-one billion two hundred thirty-four million five hundred sixty-seven thousand eight hundred ninety")]
        public void StrToNumBillionsTest(long res, string num)
        {
            Assert.AreEqual(res, Functions.StrToNumBillions(num));
        }

        [DataTestMethod]
        [DataRow(0, 0, 0, 0, 0)]
        [DataRow(10, 10, 10, 10, 0)]
        [DataRow(-10, -2, -10, 10, 12)]
        [DataRow(4, 2, 3, 1, 1)]
        public void LengthBetweenPointsTest(int x1, int x2, int y1, int y2, int res)
        {
            Assert.AreEqual(res, Functions.LengthBetweenPoints(x1, x2, y1, y2));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StrToNum999TestEx()
        {
            int res = Functions.StrToNum999("Whatever");
        }
        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(2, "two")]
        [DataRow(3, "three")]
        [DataRow(4, "four")]
        [DataRow(5, "five")]
        [DataRow(6, "six")]
        [DataRow(7, "seven")]
        [DataRow(8, "eight")]
        [DataRow(9, "nine")]
        [DataRow(10, "ten")]
        [DataRow(11, "eleven")]
        [DataRow(12, "twelve")]
        [DataRow(13, "thirteen")]
        [DataRow(14, "fourteen")]
        [DataRow(15, "fifteen")]
        [DataRow(16, "sixteen")]
        [DataRow(17, "seventeen")]
        [DataRow(18, "eighteen")]
        [DataRow(19, "nineteen")]
        [DataRow(20, "twenty")]
        [DataRow(30, "thirty")]
        [DataRow(40, "fourty")]
        [DataRow(50, "fifty")]
        [DataRow(60, "sixty")]
        [DataRow(70, "seventy")]
        [DataRow(80, "eighty")]
        [DataRow(90, "ninety")]
        [DataRow(100, "one hundred")]
        [DataRow(24, "twenty-four")]
        [DataRow(314, "three hundred fourteen")]
        [DataRow(999, "nine hundred ninety-nine")]
        public void StrToNum999Test(int res, string num)
        {
            Assert.AreEqual(res, Functions.StrToNum999(num));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NumToStr999TestEx_m1()
        {
            string res = Functions.NumToStr999(-1);
        }
        [DataTestMethod]
        [DataRow(0, "zero")]
        [DataRow(1, "one")]
        [DataRow(2, "two")]
        [DataRow(3, "three")]
        [DataRow(4, "four")]
        [DataRow(5, "five")]
        [DataRow(6, "six")]
        [DataRow(7, "seven")]
        [DataRow(8, "eight")]
        [DataRow(9, "nine")]
        [DataRow(10, "ten")]
        [DataRow(11, "eleven")]
        [DataRow(12, "twelve")]
        [DataRow(13, "thirteen")]
        [DataRow(14, "fourteen")]
        [DataRow(15, "fifteen")]
        [DataRow(16, "sixteen")]
        [DataRow(17, "seventeen")]
        [DataRow(18, "eighteen")]
        [DataRow(19, "nineteen")]
        [DataRow(20, "twenty")]
        [DataRow(30, "thirty")]
        [DataRow(40, "fourty")]
        [DataRow(50, "fifty")]
        [DataRow(60, "sixty")]
        [DataRow(70, "seventy")]
        [DataRow(80, "eighty")]
        [DataRow(90, "ninety")]
        [DataRow(100, "one hundred")]
        [DataRow(24, "twenty-four")]
        [DataRow(314, "three hundred fourteen")]
        [DataRow(999, "nine hundred ninety-nine")]
        public void NumToStr999Test(int num, string res)
        {
            Assert.AreEqual(res, Functions.NumToStr999(num));
        }
    }
}
