using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    public class Functions
    {
        public static string DayOfWeek(int num)
        {
            switch (num)
            {
                case 2:
                    return "Monday";
                case 3:
                    return "Tuesday";
                case 4:
                    return "Wednesday";
                case 5:
                    return "Thursday";
                case 6:
                    return "Friday";
                case 7:
                    return "Saturday";
                case 1:
                    return "Sunday";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static string NumToStr999(int num)
        {
            if (num < 0) throw new ArgumentException();
            if (num == 0) return "zero";

            string result = "";

            string[] onesArray = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tenArray = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] decsArray = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int hundreds = num / 100;
            int decads = (num % 100) / 10;
            int ones = num % 10;

            if (hundreds != 0)
                result += onesArray[hundreds] + " hundred ";
            if (decads != 0)
            {
                if (decads != 1)
                {
                    result += decsArray[decads];
                    if (ones != 0)
                        result += "-" + onesArray[ones] + " ";
                    else
                        result += " ";
                }
                else
                {
                    result += tenArray[ones] + " ";
                }
            }
            else
            {
                result += onesArray[ones] + " ";
            }
            result = result.Trim();

            return result;
        }

        public static int StrToNum999(string str)
        {
            if (str == "zero") return 0;

            string[][] library = new string[4][];
            library[0] = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            library[1] = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            library[2] = new string[] { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            library[3] = new string[] { "", "hundred" };

            bool flag = false;

            str = str.Replace('-', ' ');
            Array strArray = str.Split(' ');

            int res = 0;

            foreach (string value in strArray)
            {
                foreach (string[] dimension in library)
                {
                    if (dimension.Contains(value))
                    {
                        int i = Array.IndexOf(dimension, value);
                        flag = true;
                        if (dimension[1] == "one")
                            res += i;
                        else if (dimension[1] == "eleven")
                            res += 10 + i;
                        else if (dimension[1] == "ten")
                            res += 10 * i;
                        else if (dimension[1] == "hundred")
                            res *= 100;
                        break;
                    }
                }
                if (flag == false)
                    throw new ArgumentException();
                flag = false;
            }

            return res;
        }

        public static long StrToNumBillions(string str)
        {
            if (str == "zero") return 0;

            string[][] library = new string[5][];
            library[0] = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            library[1] = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            library[2] = new string[] { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            library[3] = new string[] { "", "thousand", "million", "billion" };
            library[4] = new string[] { "", "hundred"};

            bool flag = false;

            str = str.Replace('-', ' ');
            Array strArray = str.Split(' ');

            long tempRes = 0;
            long result = 0;

            foreach(string value in strArray)
            {              
                foreach (string[] dimension in library)
                {                  
                    if (dimension.Contains(value))
                    {
                        int i = Array.IndexOf(dimension,value);
                        flag = true;
                        if (dimension[1] == "one")
                        {
                            tempRes += i;
                        }
                        else if (dimension[1] == "eleven")
                        {
                            tempRes += 10 + i;
                        }
                        else if (dimension[1] == "ten")
                        {
                            tempRes += 10 * i;
                        }
                        else if (dimension[1] == "hundred")
                        {
                            tempRes *= 100;
                        }
                        else if (dimension[1] == "thousand")
                        {
                            tempRes *= (int)Math.Pow(1000, i);
                            result += tempRes;
                            tempRes = 0;
                        }
                        break;
                    }
                }
                if (flag == false)
                    throw new ArgumentException();
                flag = false;
            }
            result += tempRes;
            return result;
        }

        public static string NumToStrBillions(long num)
        {
            if (num < 0) throw new ArgumentException();
            if (num == 0) return "zero";
            
            string result = "";

            string[] onesArray = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tenArray = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] decsArray = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            string[] thousandsArray = { "billion ", "million ", "thousand ", ""};

            long drop = 1;
            for (int j = 0; j < 4; j++)
            {
                long div = (long)Math.Pow(1000, 3 - j);
                int tempNum = Convert.ToInt32(num / div);

                int hundreds = tempNum / 100;
                int decads = (tempNum % 100) / 10;
                int ones = tempNum % 10;

                if (hundreds != 0)
                {
                    result += onesArray[hundreds] + " hundred ";
                }
                if (decads != 0)
                {
                    if (decads != 1)
                    {
                        result += decsArray[decads];
                        if (ones != 0)
                            result += "-" + onesArray[ones] + " ";
                        else
                            result += " ";
                    }
                    else
                    {
                        result += tenArray[ones] + " ";
                    }
                }
                else
                {
                    result += onesArray[ones] + " ";
                }
                if (hundreds + decads + ones != 0)
                {
                    result += thousandsArray[j];
                }
                num -= tempNum * div;
            }
            result = result.Trim(' ');

            return result;
        }

        public static int LengthBetweenPoints(int x0, int y0, int x1, int y1)
        {
            int res = 0;

            int A = (x1 - x0) * (x1 - x0);
            int B = (y1 - y0) * (y1 - y0);
            res = Loops.SqrtOrdinary(A + B);

            return res;
        }
    }

}
