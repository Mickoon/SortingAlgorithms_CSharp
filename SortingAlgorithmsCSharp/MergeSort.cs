using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class MergeSort
    {
        /* Create inner groups and sort them individually, and then merge them into a new array.
         * A typical example of an algorithm that can be implemented with recursion.
         * Every time, two elements are compared and swapped each other.
         * It is stable, because it maintains ordering of input with equal keys in the sorted output.  
         *  e.g. the list represents "earlier" positions in each merge has priority if two elements are equal.
         */
        public static void MergeMain (float[] inputArray)
        {
            Console.WriteLine("* Best case: O(n) or O(n log n)\n" +
                "* Average case: O(n log n)\n" +
                "* Worst case: O(n log n)\n" +
                "* Stability: stable");
            int left = 0;
            int right = inputArray.Length - 1;
            InnerMergeSort(inputArray, left, right);
        }

        private static void InnerMergeSort(float[] inputArray, int left, int right)
        {
            int mid = 0;
            if (left < right)
            {
                mid = (left + right) / 2;
                InnerMergeSort(inputArray, left, mid);
                InnerMergeSort(inputArray, (mid + 1), right);
                MergeSortedArray(inputArray, left, mid, right);
            }
        }

        private static void MergeSortedArray(float[] inputArray, int left, int mid, int right)
        {
            int index = 0;
            int total_elements = right - left + 1;
            int right_start = mid + 1;
            int temp_location = left;
            float[] tempArray = new float[total_elements];

            while ((left <= mid) && right_start <= right)
            {
                if (inputArray[left] <= inputArray[right_start])
                {
                    tempArray[index++] = inputArray[left++];
                }
                else
                {
                    tempArray[index++] = inputArray[right_start++];
                }
            }

            if (left > mid)
            {
                for (int j = right_start; j <= right; j++)
                    tempArray[index++] = inputArray[right_start++];
            }
            else
            {
                for (int j = left; j <= mid; j++)
                    tempArray[index++] = inputArray[left++];
            }

            for (int i = 0, j = temp_location; i < total_elements; i++, j++)
            {
                inputArray[j] = tempArray[i];
            }
        }
    }
}
