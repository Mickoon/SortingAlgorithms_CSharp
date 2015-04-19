using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class Insertion_Sort
    {
        public static void InsertionMain(float[] inputArray)
        {
            /* Simple sorting method, efficient for small lists and mostly-sorted lists.
             * It works by taking elements from the list one by one 
             *  and insert into their correct position into a new sorted list.
             * Shell sort is a variant for Insertion Sort, better for larger lists, 
             *  because in arrays, insertion is expensive and requires a long time to move all elements over by one.
            */

            Console.WriteLine("* Best case: O(n)\n" +
                "* Average case: O(n^2)\n" +
                "* Worst case: O(n^2)\n" +
                "* Stability: stable");

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
