using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class BubbleSort
    {
        public static void BubbleMain(float[] inputArray)
        {
            /* Straightforward and simple.
             * Comparing the first two elements, and if the first is greater than the second,
             *  then it swaps them. It continues to the end of the data set,
             *  then it starts again, repeating until no swaps have occurred on the last pass.
             * Highly inefficient, and is rarely used.
            */

            Console.WriteLine("* Best case: O(n)\n" +
                "* Average case: O(n^2)\n" +
                "* Worst case: O(n^2)\n" +
                "* Stability: stable");

            for (int k = 0; k < inputArray.Length; k++)
            {
                for (int i = 0; i < inputArray.Length -1; i++)
                {
                    if (inputArray[i] > inputArray[i + 1])
                        swap(inputArray, i, i + 1);
                }
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
