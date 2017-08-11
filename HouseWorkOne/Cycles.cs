using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    public class Cycles
    {
        public static int Task1_1()
        {
            int sum = 0;

            for (int i = 1; i <= 99; i++)
                if (i % 2 == 0)
                    sum += i;

            return sum;
        }

        public static int Task1_2()
        {
            int count = 0;

            for (int i = 1; i <= 99; i++)
                if (i % 2 == 0)
                    count++;

            return count;
        }

        public static bool Task2(int num)
        {
            if (num <= 1)
                return false;

            bool res = true;

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    res = false;
                    break;
                }
            }

            return res;
        }

        public static int Task3_1(int num)   //binary search
        {
            if (num < 0)
                throw new ArgumentException();

            int res = 0;

            int begin = 0, end = num;
            while (begin < end)
            {
                int mid = begin + (end - begin) / 2;
                if (mid * mid == num)
                {
                    res = mid;
                    break;
                }
                else if (mid * mid > num)
                {
                    end = mid;
                }
                else
                {
                    begin = mid + 1;
                }
            }
            if (end * end != num)
                if ((end * end - num >= num - (end - 1) * (end - 1)))
                    res = end - 1;
                else
                    res = end;

            return res;
        }
        public static int Task3_2(int num)   //ordinary search
        {
            if (num < 0)
                throw new ArgumentException();

            int res = 0;

            for (int i = 0;i <= num; i++)
            {
                if (i * i == num)
                {
                    res = i;
                }
                else if (i * i > num)
                {
                    res = i - 1;
                    break;
                }
            }

            return res;
        }

        public static long Task4(int num)
        {
            if (num < 0)
                throw new ArgumentException();

            long res = 0;

            if (num == 0)
                res = 1;
            else
                res = num * Task4(num - 1);

            return res;
        }

        public static int Task5(int num)
        {
            int sum = 0;

            if (num < 0)
                num *= -1;

            int drop = num;
            int len = num.ToString().Length;
            int k = 1;

            for (int i = 0; i < len-1; i++)
                k *= 10;

            for (int i = k; drop != 0; i /= 10)
            {
                sum += (drop / i);
                drop = drop % i;
            }

            return sum;
        }

        public static int Task6(int num)
        {
            int result = 0;

            if (num < 0)
                num *= -1;

            int drop = num;
            int len = num.ToString().Length;
            int k = 1;

            for(int i = 0;i < len-1;i++)
                k *= 10;

            for (int i = k, count = 1; drop != 0; i /= 10, count *= 10)
            {
                result += (drop / i) * count;
                drop = drop % i;
            }

            return result;
        }
    }
}
