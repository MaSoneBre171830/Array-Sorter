using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class QuickSort
    {
        private int[] arr; //declares an array

        public double sortTime { get; private set; }


        //constructor for to initialise the array
        public QuickSort(int[] arr)
        {
            this.arr = arr;
            int[] dummyArray = new int[] { 3, 1, 2, 5, 4 };
            QuickSortArray(dummyArray, 0, dummyArray.Length - 1);
        }

        //another constructor to initialise the array if the user inputs a list
        public QuickSort(List<int> l)
        {
            this.arr = l.ToArray();
            int[] dummyArray = new int[] { 3, 1, 2, 5, 4 };
            QuickSortArray(dummyArray, 0, dummyArray.Length - 1);
        }

        public int[] Sort()
        {
            Stopwatch sw = new Stopwatch(); // Create a fresh Stopwatch instance for each sort
            sw.Start(); // Start the stopwatch

            QuickSortArray(arr, 0, arr.Length - 1); // Call the QuickSort method

            sw.Stop(); // Stop the stopwatch
            sortTime = sw.Elapsed.TotalNanoseconds; // Store the elapsed time in milliseconds

            return arr; // Return
        }

        private void QuickSortArray(int[] array, int low, int high)
        {
            if (low < high)
            {
                // Partition the array
                int pi = Partition(array, low, high);

                // Recursively sort the partitions
                QuickSortArray(array, low, pi - 1);
                QuickSortArray(array, pi + 1, high);
            }
        }

        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high]; // Choose the last element as the pivot
            int i = low - 1; // Pointer for the smaller element

            for (int j = low; j < high; j++)
            {
                // If the current element is smaller than or equal to the pivot
                if (array[j] <= pivot)
                {
                    i++; // Increment the pointer
                    // Swap the elements
                    int temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
            // Swap the pivot element with the element at i + 1
            int temp1 = array[i + 1];
            array[i + 1] = array[high];
            array[high] = temp1;

            return i + 1; // Return the partitioning index
        }

        //prints the array and the elapsed time it took to sort the array
        public void PrintNums()
        {
            Console.WriteLine(String.Join(", ", arr));


        }
    }
}
