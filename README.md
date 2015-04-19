# Sorting Algorithms - C# 
You can try the following sorting methods in this program: 
- MergeSort
- QuickSort
- HeapSort
- BubbleSort
- ShellSort
- Selection Sort
- Insertion Sort

For trying these methods, you need to enter an appropriate example.

Input Format: number1 number2 number3 number4

A positive, negative, decimal or zero is allowed for input numbers.


NOTE: This program can be easily run with Microsoft Visual Studio. 

NOTE: MainProgram.cs is a main cs file

## Merge Sort
This algorithm creates inner groups and sorts them individually, and then merges them into a new array.

A typical example of an algorithm that can be implemented with recursion.

Every time, two elements are compared and swapped each other.

It is stable, because it maintains ordering of input with equal keys in the sorted output.

For example, the list represents "earlier" positions in each merge has priority if two elements are equal.

* Best case: O(n) or O(n log n)
* Average case: O(n log n)
* Worst case: O(n log n)
* Stability: stable


## Quick Sort
Divide and Conquer algorithm, replies on a partition operation.

To partition on array, choose an element called a pivot, move all smaller elements before the pivot,
and move all greater elements after the pivot. Later, recursively sort the lesser and greater sublists.

* Best case: O(n log n)
* Average case: O(n log n)
* Worst case: O(n^2)
* Stability: Depends on how the pivot if handled


## Heap Sort
Comparision-based sorting algorithm, and is part of the Selection Sort family.

As good as Quick Sort, but works better in worst-case.

It begins by building a heap out of the data set, and then removing the largest item and placing it at the end of the sorted array.

After removing the largest item, it reconstructs the heap, and place the largest item in the next position from the end of the sorted array.

This is repeated till there are no items left in the heap and the sorted array is full.

* Best case: O(n log n)
* Average case: O(n log n)
* Worst case: O(n log n)
* Stability: unstable


## Bubble Sort
Simple sorting method, efficient for small lists and mostly-sorted lists.

It works by taking elements from the list one by one, and insert into their correct position into a new sorted list.

Shell sort is a variant for Insertion Sort, better for larger lists, because in arrays, insertion is expensive and requires a long time to move all elements over by one.

* Best case: O(n)
* Average case: O(n^2)
* Worst case: O(n^2)
* Stability: stable


## Shell Sort
Improved sort methods from Bubble Sort and Insertion Sort by moving out of order elements more than one position at a time.

It compares elements separated by a gap of several positions.

* Best case: O(n)
* Average case: Depends on gap sequence
* Worst case: O(n^2) or O(nlog^2n)
* Stability: unstable


## Selection Sort
All cases has O(n^2) complexity, which is not efficient on large lists.

Similar to Insertion Sort but worse.

Simplicity is its strong point, so it performs great in complicated algorithms.

It performs better than Bubble Sort in most cases.
		 
* Best case: O(n^2)
* Average case: O(n^2)
* Worst case: O(n^2)
* Stability: Depends on the implementation, normally stable


## Insertion Sort
Simple sorting method, efficient for small lists and mostly-sorted lists.

It works by taking elements from the list one by one and insert into their correct position into a new sorted list.

Shell sort is a variant for Insertion Sort, better for larger lists, because in arrays, insertion is expensive and requires a long time to move all elements over by one.
		 
* Best case: O(n)
* Average case: O(n^2)
* Worst case: O(n^2)
* Stability: stable	 

