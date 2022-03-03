using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithems
{
    public class SortingHelpers

    {
        public static int MaxIndex(int[] arr, int start, int end)
        {
            int maxindex = start;
            int maxvalue = arr[start];
            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] > maxvalue)
                {
                    maxvalue = arr[i];
                    maxindex = i;
                }
            }
            return maxindex;
        }

        public static int MinIndex(int[] arr, int start, int end)
        {
            int minindex = start;
            int minvalue = arr[start];
            for (int i = start + 1; i <= end; i++)
            {
                if (arr[i] < minvalue)
                {
                    minvalue = arr[i];
                    minindex = i;
                }
            }
            return minindex;
        }

        public static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        public static void Shift(int[] arr, int from, int to)
        {
            for (int i = from; i > to; i--)
            {
                arr[i] = arr[i - 1];
            }
        }


    }
}
