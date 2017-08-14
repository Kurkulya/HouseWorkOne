using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    public class Loops
    {
        public static int EvensSumOf100()
        {
            int sum = 0;

            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 == 0)
                    sum += i;
            }
            return sum;
        }

        public static int EvensCountOf100()
        {
            int count = 0;

            for (int i = 1; i <= 99; i++)
            {
                if (i % 2 == 0)
                    count++;
            }

            return count;
        }

        public static bool IsSimple(int num)
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

        public static int SqrtBinary(int num)   //binary search
        {
            if (num < 0)
                throw new ArgumentException();

            int res = 0;
            
            int begin = 0;
            int end = num;
            while (end - begin > 1)
            {      
                int mid = (begin + end) / 2;
                int cur = mid * mid;

                if (cur < num)
                {
                    begin = mid;
                }
                else if (cur > num)
                {
                    end = mid;
                    res = mid;
                }
                else
                {
                    res = mid;
                    break;
                }
            }
            if (res * res > num)
                res--;

            return res;
        }
        public static int SqrtOrdinary(int num)   //ordinary search
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

        public static long Factorial(int num)
        {
            if (num < 0)
                throw new ArgumentException();

            long res = 0;

            if (num == 0)
                res = 1;
            else
                res = num * Factorial(num - 1);

            return res;
        }

        public static int SumOfDigits(int num)
        {
            int sum = 0;

            if (num < 0)
                num *= -1;

            int drop = num;
            int len = num.ToString().Length;
            int k = 1;

            for (int i = 0; i < len - 1; i++)
            {
                k *= 10;
            }

            for (int i = k; drop != 0; i /= 10)
            {
                sum += (drop / i);
                drop = drop % i;
            }

            return sum;
        }

        public static int ReverseDigits(int num)
        {
            int result = 0;

            if (num < 0)
                num *= -1;

            int drop = num;
            int len = num.ToString().Length;
            int k = 1;

            for (int i = 0; i < len - 1; i++)
            {
                k *= 10;
            }

            for (int i = k, count = 1; drop != 0; i /= 10, count *= 10)
            {
                result += (drop / i) * count;
                drop = drop % i;
            }

            return result;
        }
    }
}
