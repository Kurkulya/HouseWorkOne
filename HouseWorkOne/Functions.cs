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

        public static long StrToNum(string str)
        {
            if (str == "zero") return 0;

            string[][] library = new string[5][];
            library[0] = new string[] { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            library[1] = new string[] { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            library[2] = new string[] { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
            library[3] = new string[] { "", "thousand", "million", "billion" };
            library[4] = new string[] { "", "hundred"};

            //char[] temp = str.ToCharArray();
            bool flag = false;

            str = str.Replace('-', ' ');
            Array strArray = str.Split(' ');
            Array.Reverse(strArray);

            Stack<long> result = new Stack<long>();

            foreach(string value in strArray)
            {       
                foreach(string[] dimension in library)
                {
                    if (dimension.Contains(value))
                    {
                        int i = Array.IndexOf(dimension,value);
                        flag = true;
                        if (dimension[1] == "one") result.Push(i);
                        else if (dimension[1] == "eleven") result.Push(10 + i);
                        else if (dimension[1] == "ten") result.Push(10 * i);
                        else if (dimension[1] == "hundred") result.Push(100);
                        else if (dimension[1] == "thousand") result.Push(-1*(int)Math.Pow(1000,i));
                        break;
                    }
                }
                if (flag == false)
                    throw new ArgumentException();
                flag = false;
            }

            long tempSum = 0;
            long resSum = 0;
            long el = 0;
            while(result.Count != 0)
            {
                el = result.Pop();
                if (el >= 0)
                {
                    if (el != 100)
                        tempSum += el;
                    else
                        tempSum *= el;
                }
                else
                {
                    tempSum *= (-1) * el;
                    resSum += tempSum;
                    tempSum = 0;
                }
            }
            resSum += tempSum;

            return resSum;
        }

        public static string NumToStr(long num)
        {
            if (num < 0) throw new ArgumentException();
            if (num == 0) return "zero";
            
            string result = "";

            string[] onesArray = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            string[] tenArray = { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            string[] decsArray = { "", "ten", "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };

            int[] value = { 0,0,0,0,0,0,0,0,0,0,0,0};

            string billions = "";
            string millions = "";
            string thousands = "";
            string other = "";
            string[] dimensions = { billions, millions, thousands, other };

            string str = num.ToString();
            for (int i = 12 - str.Length; i < 12; i++)
                value[i] = (int)Char.GetNumericValue((str[i-(12 - str.Length)]));

            for (int j = 0; j < 4; j++)
            {
                int hundreds = value[3 * j];
                int decads = value[3 * j + 1];
                int ones = value[3 * j + 2];

                if (hundreds != 0)
                    dimensions[j] += onesArray[hundreds] + " hundred ";

                if (decads != 0)
                {
                    if (decads != 1)
                    {
                        dimensions[j] += decsArray[decads];
                        if (ones != 0)
                            dimensions[j] += "-" + onesArray[ones] + " ";
                        else
                            dimensions[j] += " ";
                    }
                    else
                    {
                        dimensions[j] += tenArray[ones] + " ";
                    }
                }
                else
                {
                    dimensions[j] += onesArray[ones] + " ";
                }
                if (hundreds + decads + ones != 0)
                {
                    switch (j)
                    {
                        case 0:
                            dimensions[j] += "billion ";
                            continue;
                        case 1:
                            dimensions[j] += "million ";
                            continue;
                        case 2:
                            dimensions[j] += "thousand ";
                            continue;
                        case 3:
                            break;
                    }
                }
            }
            result = string.Join("", dimensions).Trim(' ');

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
