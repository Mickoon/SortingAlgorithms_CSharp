/* All codes in this program are developed by Mickoon - 2015 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithmsCSharp
{
    class MainProgram
    {
        static void Main(string[] args)
        {
            // Instruction
            Console.WriteLine(
                " Sorting Algorithms - C# \n\n" +
                "You can try the following sorting methods: \n" +
                "MergeSort, QuickSort, HeapSort, BubbleSort, ShellSort, Selection Sort and Insertion Sort\n\n" +
                "For trying these methods, you need to enter an appropriate example.\n" +
                "* Input Format: number1 number2 number3 number4\n" +
                "* A positive, negative, decimal or zero is allowed for input numbers" +
                "* A space is required to be inserted between numbers.\n"
                );
            ////

            UserInputProcess();            
        }

        // Read the user's input
        private static void UserInputProcess()
        {
            Console.Write("Enter your input (Type \"q\" to exit): ");
            string input = Console.ReadLine();
            if (input.ToLower().Replace(" ", "") == "q" || 
                input.ToLower().Replace(" ", "") == "quit")
            {
                Environment.Exit(0);
            }
            else if (input != "")
            {
                // Remove all unnecesary spaces
                input = input.Replace("  ", " ");
                // Numbers of User's input are pushed in a string array
                string[] inputArray = input.Split(' ');
                try
                {
                    // Convert String array to float array
                    float[] inputNums = Array.ConvertAll(inputArray, s => float.Parse(s));
                    // After we checked the user typed in a correct format of input, let the user choose a sorting method
                    SortingSelection(inputNums);
                    UserInputProcess();
                }
                catch (FormatException) // if non-numbers are entered, let user type in a new input
                {
                    Console.Error.WriteLine("ERROR: Please enter NUMBERS only in your input.\n");
                    UserInputProcess();
                }
            }
        }

        // Show the list of sorting methods
        private static void SortingSelection(float[] inputNums)
        {
            string userInput = "{";
            for (int i = 0; i < inputNums.Length-1; i++)
                userInput += inputNums[i] + ", ";
            userInput += inputNums[inputNums.Length - 1] + "}";

            Console.WriteLine("Now please choose a sorting method (Enter a number):\n" +
                        "1. Merge Sort\n" +
                        "2. Quick Sort\n" +
                        "3. Heap Sort\n" +
                        "4. Bubble Sort\n" +
                        "5. Shell Sort\n" +
                        "6. Selection Sort\n" +
                        "7. Insertion Sort\n"
                        );
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();
            int inputInt;
            if (int.TryParse(input, out inputInt))
            {
                Console.WriteLine("Your input is " + userInput);
                float[] userInputArray = inputNums;
                DateTime now = DateTime.Now;
                switch (inputInt)
                {
                    case 1:
                        Console.WriteLine("[" + DateTime.Now + "] Merge Sort starts");
                        MergeSort.MergeMain(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    case 2:
                        Console.WriteLine("[" + DateTime.Now + "] Quick Sort starts");
                        QuickSort.QuickMain(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    case 3:
                        Console.WriteLine("[" + DateTime.Now + "] Heap Sort starts");
                        HeapSort.HeapMain(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    case 4:
                        Console.WriteLine("[" + DateTime.Now + "] Bubble Sort starts");
                        BubbleSort.BubbleMain(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    case 5:
                        Console.WriteLine("[" + DateTime.Now + "] Shell Sort starts");
                        ShellSort.ShellMain(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    case 6:
                        Console.WriteLine("[" + DateTime.Now + "] Selection Sort starts");
                        Selection_Sort.SelectionSort(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    case 7:
                        Console.WriteLine("[" + DateTime.Now + "] Insertion Sort starts");
                        Insertion_Sort.InsertionMain(inputNums);
                        ShowResult(inputNums, now);
                        break;
                    default:
                        break;
                }

                Console.WriteLine("\nDo you want to try another sorting method with the same input? (Y/N)");
                input = Console.ReadLine();
                if (input.ToLower().Replace(" ", "") == "y" || 
                    input.ToLower().Replace(" ", "") == "yes")
                {
                    Console.WriteLine("");
                    SortingSelection(userInputArray);
                }
            }
            else
            {
                Console.WriteLine("Sorry, please enter a number only for your selection.");
                SortingSelection(inputNums);
            }
        }

        public static void ShowResult(float[] inputNums, DateTime started)
        {
            TimeSpan elapsed = DateTime.Now - started;
            double elapsedMS = elapsed.TotalMilliseconds;
            string outcome = "{";
            for (int i = 0; i < inputNums.Length - 1; i++)
                outcome += inputNums[i] + ", ";
            outcome += inputNums[inputNums.Length - 1] + "}";
            Console.WriteLine("Sorted Array: " + outcome);
            Console.WriteLine("Elapsed Time (milliseconds): " + elapsedMS);
        }
    }
}
