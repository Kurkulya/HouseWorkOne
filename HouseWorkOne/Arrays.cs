using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseWorkOne
{
    public class Arrays
    {
        public static int Min(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length == 0)
                throw new IndexOutOfRangeException();

            int min = arr[0];

            foreach (int i in arr)
                if (i < min)
                    min = i;
            return min;
        }

        public static int Max(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length == 0)
                throw new IndexOutOfRangeException();

            int max = arr[0];

            foreach (int i in arr)
                if (i > max)
                    max = i;

            return max;
        }

        public static int IndexOfMin(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length == 0)
                throw new IndexOutOfRangeException();

            int res = 0;

            int min = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    res = i;
                }
            }

            return res;
        }

        public static int IndexOfMax(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length == 0)
                throw new IndexOutOfRangeException();

            int res = 0;

            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    res = i;
                }
            }

            return res;
        }

        public static int SumOfOddsIndexesEl(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length <= 1)
                throw new IndexOutOfRangeException();

            int sum = 0;

            for (int i = 1; i < arr.Length; i += 2)
                sum += arr[i];

            return sum;
        }

        public static void Reverse(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            for (int i = 0; i < arr.Length / 2; i++)
            {
                int temp = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - 1 - i] = temp;
            }
        }

        public static int CountOfOddsEl(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            int count = 0;

            foreach (int i in arr)
                if (i % 2 != 0)
                    count++;

            return count;
        }

        public static void SwapHalfes(int[] arr)
        {
            if (arr == null)
                throw new ArgumentNullException();

            int len = arr.Length;
            if (len > 1)
            {
                for (int j = 0; j < len / 2; j++)
                {
                    int temp = arr[0];
                    for (int i = 0; i < len - 1; i++)
                        arr[i] = arr[i + 1];
                    arr[len - 1] = temp;
                }
            }
        }

        public static void BubbleSort(int[] arr) //bubble sort
        {
            if (arr == null)
                throw new ArgumentNullException();

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        public static void SelectSort(int[] arr) //select sort
        {
            if (arr == null)
                throw new ArgumentNullException();

            int min, temp;
            int length = arr.Length;

            for (int i = 0; i < length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    temp = arr[i];
                    arr[i] = arr[min];
                    arr[min] = temp;
                }
            }
        }

        public static void InsertSort(int[] arr) //insert sort
        {
            if (arr == null)
                throw new ArgumentNullException();

            for (int i = 1; i < arr.Length; i++)
            {
                int cur = arr[i];
                int j = i;
                while (j > 0 && cur < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }
                arr[j] = cur;
            }
        }

        private static int PartitionQuickSort(int[] arr, int start, int end)
        {
            int temp;
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (arr[i] < arr[end])
                {
                    temp = arr[marker];
                    arr[marker] = arr[i];
                    arr[i] = temp;
                    marker += 1;
                }
            }
            temp = arr[marker];
            arr[marker] = arr[end];
            arr[end] = temp;
            return marker;
        }

        public static int[] QuickSort(int[] arr, int start, int end) //quick sort
        {
            if (arr == null)
                throw new NullReferenceException();
            if (start < 0 || end > arr.Length - 1)
                throw new IndexOutOfRangeException();
            
            if (start >= end)
            {
                return new int[1];
            }
            int pivot = PartitionQuickSort(arr, start, end);
            QuickSort(arr, start, pivot - 1);
            QuickSort(arr, pivot + 1, end);
            return arr;
        }

        private static int[] Merge(int[] mass1, int[] mass2) 
        {
            Int32 a = 0, b = 0;
            Int32[] merged = new int[mass1.Length + mass2.Length];
            for (Int32 i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                        merged[i] = mass2[b++];
                    else //if int go for
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }

        public static int[] MergeSort(int[] arr)  //merge sort
        {
            if (arr == null)
                throw new ArgumentNullException();
            if (arr.Length <=1)
                return arr;

            Int32 mid_point = arr.Length / 2;
            return Merge(MergeSort(arr.Take(mid_point).ToArray()), MergeSort(arr.Skip(mid_point).ToArray()));
        }

        public static void ShellSort(int[] arr) //shell sort
        {
            if (arr == null)
                throw new ArgumentNullException();

            int step = arr.Length / 2;
            while (step > 0)
            {
                int i, j;
                for (i = step; i < arr.Length; i++)
                {
                    int value = arr[i];
                    for (j = i - step; (j >= 0) && (arr[j] > value); j -= step)
                        arr[j + step] = arr[j];
                    arr[j + step] = value;
                }
                step /= 2;
            }
        }

        private static Int32 add2pyramid(Int32[] arr, Int32 i, Int32 N)
        {
            Int32 imax;
            Int32 buf;
            if ((2 * i + 2) < N)
            {
                if (arr[2 * i + 1] < arr[2 * i + 2]) imax = 2 * i + 2;
                else imax = 2 * i + 1;
            }
            else imax = 2 * i + 1;
            if (imax >= N) return i;
            if (arr[i] < arr[imax])
            {
                buf = arr[i];
                arr[i] = arr[imax];
                arr[imax] = buf;
                if (imax < N / 2) i = imax;
            }
            return i;
        }

        public static void HeapSort(int[] arr) //heap sort
        {
            if (arr == null)
                throw new ArgumentNullException();

            int len = arr.Length;
            //step 1: building the pyramid
            for (int i = len / 2 - 1; i >= 0; --i)
            {
                long prev_i = i;
                i = add2pyramid(arr, i, len);
                if (prev_i != i) ++i;
            }

            //step 2: sorting
            int buf;
            for (int k = len - 1; k > 0; --k)
            {
                buf = arr[0];
                arr[0] = arr[k];
                arr[k] = buf;
                int i = 0, prev_i = -1;
                while (i != prev_i)
                {
                    prev_i = i;
                    i = add2pyramid(arr, i, k);
                }
            }
        }
    }
}
