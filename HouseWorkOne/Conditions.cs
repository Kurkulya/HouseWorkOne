using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    public class Conditions
    {
        public static int Task1(int a, int b)
        {
            int res = 0;

            if (a % 2 == 0)
                res = a * b;
            else
                res = a + b;

            return res;
        }

        public static int Task2(int x, int y)
        {
            if (x == 0 || y == 0)
                throw new ArgumentException();

            int res = 0;

            if (x > 0 && y > 0)
                res = 1;
            else if (x < 0 && y > 0)
                res = 2;
            else if (x < 0 && y < 0)
                res = 3;
            else
                res = 4;

            return res;
        }

        public static int Task3(int a, int b, int c)
        {
            int sum = 0;

            if (a > 0)
                sum += a;
            if (b > 0)
                sum += b;
            if (c > 0)
                sum += c;

            return sum;
        }

        public static int Task4(int a, int b, int c)
        {
            int res = 0;

            if (a * b * c > a + b + c)
                res = (a * b * c) + 3;
            else
                res = (a + b + c) + 3;

            return res;
        }

        public static char Task5(int score)
        {
            if (score < 0 || score > 100)
                throw new ArgumentOutOfRangeException();

            char res = '0';

            if (score >= 0 && score <= 19)
                res = 'F';
            else if (score >= 20 && score <= 39)
                res = 'E';
            else if (score >= 40 && score <= 59)
                res = 'D';
            else if (score >= 60 && score <= 74)
                res = 'C';
            else if (score >= 75 && score <= 89)
                res = 'B';
            else
                res =  'A';

            return res;
        }
    }
}
