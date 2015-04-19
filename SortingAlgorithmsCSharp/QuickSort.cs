using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class QuickSort
    {
        public static void QuickMain(float[] inputArray)
        {
            /* Divide and Conquer algorithm, replies on a partition operation
             * To partition on array, choose an element called a pivot,
             *  move all smaller elements before the pivot,
             *  and move all greater elements after the pivot.
             *  Later, recursively sort the lesser and greater sublists.
            */

            Console.WriteLine("* Best case: O(n log n)\n" +
                "* Average case: O(n log n)\n" +
                "* Worst case: O(n^2)\n" +
                "* Stability: Depends on how the pivot if handled");

            InternalQuickSort(inputArray, 0, inputArray.Length - 1);
        }

        private static void InternalQuickSort(float[] inputArray, int low, int high)
        {
            if (low + 10 > high)    
                InsertionSort(inputArray);
            else
            {
                int mid = (low + high) / 2;
                if (inputArray[mid] < inputArray[low]) swap(inputArray, low, high);
                if (inputArray[high] < inputArray[low]) swap(inputArray, low, high);
                if (inputArray[high] < inputArray[mid]) swap(inputArray, mid, high);

                // Plcae a pivot at index high - 1
                swap(inputArray, mid, high - 1);
                // p = median of three
                float p = inputArray[high - 1];

                int i, j;
                // Partition elements
                for (i = low, j = high - 1; ; )
                {
                    // Find inputArray[i] >= p
                    while (inputArray[++i] < p) ;
                    // Find inputArray[j] <= p
                    while (p < inputArray[--j]) ;
                    if (i < j) swap(inputArray, i, j);
                    else break;     // Leaves i -> first value >= p
                }
                // Move pivot to its correct place
                swap(inputArray, i, high - 1);
                // Divide and Conquer!
                InternalQuickSort(inputArray, low, i - 1);
                InternalQuickSort(inputArray, i + 1, high);
            }
        }

        private static void swap(float[] inputArray, int i, int j)
        {
            float temp = inputArray[i];
            inputArray[i] = inputArray[j];
            inputArray[j] = temp;
        }

        private static void InsertionSort(float[] inputArray)
        {
            for (int i = 1; i < inputArray.Length; i++)
            {
                float temp = inputArray[i];
                int k = i - 1;
                while (k >= 0 && temp < inputArray[k])
                {
                    inputArray[k + 1] = inputArray[k];
                    k--;
                }
                inputArray[k + 1] = temp;
            }
        }
    }
}
