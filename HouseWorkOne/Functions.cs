using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    public class Functions
    {
        public static string Task1(int num)
        {
            switch (num)
            {
                case 1:
                    return "Monday";
                case 2:
                    return "Tuesday";
                case 3:
                    return "Wednesday";
                case 4:
                    return "Thursday";
                case 5:
                    return "Friday";
                case 6:
                    return "Saturday";
                case 7:
                    return "Sunday";
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public static long Task3(string str)
        {
            if (str == "ноль") return 0;

            string[][] library = new string[8][];
            library[0] = new string[] { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            library[1] = new string[] { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемьнадцать", "девятьнадцать" };
            library[2] = new string[] { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            library[3] = new string[] { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            library[4] = new string[] { "тысяч", "тысяча", "тысячи", "тысячи", "тысячи", "тысяч", "тысяч", "тысяч", "тысяч", "тысяч" };
            library[5] = new string[] { "миллионов", "миллион", "миллиона", "миллиона", "миллиона", "миллионов", "миллионов", "миллионов", "миллионов", "миллионов" };
            library[6] = new string[] { "миллиардов", "миллиард", "миллиарда", "миллиарда", "миллиарда", "миллиардов", "миллиардов", "миллиардов", "миллиардов", "миллиардов" };
            library[7] = new string[] { "", "одна", "две" };
    
            char[] temp = str.ToCharArray();
            bool flag = false;
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
                        if (dimension[1] == "один" || dimension[1] == "одна") result.Push(i);
                        else if (dimension[1] == "одиннадцать") result.Push(10 + i);
                        else if (dimension[1] == "десять") result.Push(10 * i);
                        else if (dimension[1] == "сто") result.Push(100 * i);
                        else if (dimension[1] == "тысяча") result.Push(-1000);
                        else if (dimension[1] == "миллион") result.Push(-1000000);
                        else if (dimension[1] == "миллиард") result.Push(-1000000000);
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
                    tempSum += el;
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

        public static string Task2(long num)
        {
            if (num < 0) throw new ArgumentException();
            if (num == 0) return "ноль";
            
            string result = "";

            string[] oneArray = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };
            string[] decPlusOneArray = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемьнадцать", "девятьнадцать" };
            string[] decArray = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] hundredArray = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] thousandArray = { "тысяч", "тысяча", "тысячи", "тысячи", "тысячи", "тысяч", "тысяч", "тысяч", "тысяч", "тысяч"};
            string[] millionArray = { "миллионов", "миллион", "миллиона", "миллиона", "миллиона", "миллионов", "миллионов", "миллионов", "миллионов", "миллионов" };
            string[] billionArray = { "миллиардов", "миллиард", "миллиарда", "миллиарда", "миллиарда", "миллиардов", "миллиардов", "миллиардов", "миллиардов", "миллиардов"};

            int[] value = { 0,0,0,0,0,0,0,0,0,0,0,0};

            string billions = "";
            string millions = "";
            string thousands = "";
            string other = "";

            string[] dimensions = { billions, millions, thousands, other };

            List<string[]> metric = new List<string[]> { billionArray, millionArray, thousandArray };

            string str = num.ToString();
            for (int i = 12 - str.Length; i < 12; i++)
                value[i] = (int)Char.GetNumericValue((str[i-(12 - str.Length)]));

            for (int j = 0; j < 4; j++)
            {
                int hundreds = value[3 * j];
                int decads = value[3 * j + 1];
                int ones = value[3 * j + 2];

                if (hundreds != 0)
                    dimensions[j] += hundredArray[hundreds] + " ";

                if (decads != 0)
                {
                    if (decads != 1)
                        dimensions[j] += decArray[decads] + " ";
                    else
                        dimensions[j] += decPlusOneArray[ones] + " ";
                }

                if(ones != 0)
                {
                    if(decads != 1)
                    {
                        if (j != 2)
                        {
                            dimensions[j] += oneArray[ones] + " ";
                        }
                        else
                        {
                            if (ones == 1)
                            {
                                dimensions[j] += "одна ";
                            }
                            else
                            {
                                if (ones == 2)
                                    dimensions[j] += "две ";
                                else
                                    dimensions[j] += oneArray[ones] + " ";
                            }
                        }
                    }
                }
                //dims[j] += (o != 0) ? (d == 1) ? " " : (j != 2) ? ones[o]+" " : (o == 1) ? "одна " : (o == 2) ? "две " : ones[o]+" " : "";
                if (hundreds + decads + ones != 0 && j != 3)
                {
                    if (decads != 1)
                        dimensions[j] += metric.ElementAt(j)[ones] + " ";
                    else
                        dimensions[j] += metric.ElementAt(j)[0] + " ";
                }
            }
            result = string.Join("", dimensions).TrimEnd(' ');

            return result;
        }

        public static int Task4(int x0, int y0, int x1, int y1)
        {
            int res = 0;

            int A = (x1 - x0) * (x1 - x0);
            int B = (y1 - y0) * (y1 - y0);
            res = Cycles.Task3_2(A + B);

            return res;
        }
    }

}
