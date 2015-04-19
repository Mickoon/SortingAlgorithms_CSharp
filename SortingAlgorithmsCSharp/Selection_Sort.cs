using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class Selection_Sort
    {
        /* All cases has O(n^2) complexity, which is not efficient on large lists.
         * Similar to Insertion Sort but worse.
         * Simplicity is its strong point, so it performs great in complicated algorithms
         * It performs better than Bubble Sort in most cases.
         */
        public static void SelectionSort(float[] inputArray)
        {
            Console.WriteLine("* Best case: O(n^2)\n" +
                "* Average case: O(n^2)\n" +
                "* Worst case: O(n^2)\n" +
                "* Stability: Depends on the implementation");

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                int minIndex = i;
                int j;
                for (j = i + 1; j < inputArray.Length; j++)
                {
                    if (inputArray[minIndex] > inputArray[j])
                        minIndex = j;
                }

                // Swap inputArray[i] and inputArray[minIndex]
                if (minIndex != i)
                {
                    float temp = inputArray[i];
                    inputArray[i] = inputArray[minIndex];
                    inputArray[minIndex] = temp;
                }
            }
        }
    }
}
