using System;

namespace SortingAlgorithems
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 6, 1, 8, 4, 2, 9 };
            //SortsMethods.SelectionSort(arr);
             SortsMethods.BubbleSort(arr);
           // SortsMethods.InsertionSort(arr);
            
            
            for (int i = 0; i < arr.Length-1; i++)
            {
                Console.Write(arr[i] + ",");

            }
            Console.WriteLine(arr[arr.Length-1]);

            bool found=SortingHelpers.BinarySearch(arr, 8);
            found = SortingHelpers.BinarySearch(arr, 12);
            found = SortingHelpers.BinarySearch(arr, 3);
        }
    }
}
