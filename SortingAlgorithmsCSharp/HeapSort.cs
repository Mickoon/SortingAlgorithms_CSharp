using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class HeapSort
    {
        public static void HeapMain(float[] inputArray)
        {
            /* Comparision-based sorting algorithm, and is part of the Selection Sort family.
             * As good as Quick Sort, but works better in worst-case.
             * It begins by building a heap out of the data set,
             *  and then removing the largest item and placing it at the end of the sorted array.
             *  After removing the largest item, it reconstructs the heap, 
             *  and place the largest item in the next position from the end of the sorted array.
             *  This is repeated till there are no items left in the heap and the sorted array is full.
            */

            Console.WriteLine("* Best case: O(n log n)\n" +
                "* Average case: O(n log n)\n" +
                "* Worst case: O(n log n)\n" +
                "* Stability: unstable");

            for (int i = (inputArray.Length / 2) - 1; i >= 0; i--)
                HeapFunction(inputArray, i, inputArray.Length);

            for (int i = inputArray.Length - 1; i >= 1; i--)
            {
                swap(inputArray, 0, i);
                HeapFunction(inputArray, 0, i - 1);
            }
        }

        private static void HeapFunction(float[] inputArray, int root, int bottom)
        {
            bool completed = false;
            int maxItem;    // the largest item 

            while ((root * 2 <= bottom) && (!completed))
            {
                if (root * 2 == bottom)
                    maxItem = root * 2;
                else if (inputArray[root * 2] > inputArray[root * 2 + 1])
                    maxItem = root * 2;
                else
                    maxItem = root * 2 + 1;

                if (maxItem >= inputArray.Length) maxItem = inputArray.Length - 1;
                if (inputArray[root] < inputArray[maxItem])
                {
                    swap(inputArray, root, maxItem);
                    root = maxItem;
                }
                else
                    completed = true;
            }
        }

        private static void swap(float[] inputArray, int i, int j)
        {
            float temp = inputArray[i];
            inputArray[i] = inputArray[j];
            inputArray[j] = temp;
        }
    }
}
