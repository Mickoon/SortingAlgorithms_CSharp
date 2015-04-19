using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class ShellSort
    {
        public static void ShellMain(float[] inputArray)
        {
            /* Improved sort methods from Bubble Sort and Insertion Sort
             *  by moving out of order elements more than one position at a time.
             * It compares elements separated by a gap of several positions.
            */

            Console.WriteLine("* Best case: O(n)\n" +
                "* Average case: Depends on gap sequence\n" +
                "* Worst case: O(n^2) or O(nlog^2n)\n" +
                "* Stability: unstable");

            for (int gap = inputArray.Length / 2; gap > 0;
                gap = gap == 2 ? 1 : (int)(gap / 2.2))
            {
                for (int i = gap; i < inputArray.Length; i++)
                {
                    float temp = inputArray[i];
                    int j = i;
                    for (; j >= gap && temp - inputArray[j - gap] < 0; j -= gap)
                        inputArray[j] = inputArray[j - gap];
                    inputArray[j] = temp;
                }
            }
        }
    }
}
