using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class InsertionSort
    {
        private int[] arr; //declares an array
         
        public double sortTime { get; private set; } // declares a variable to store the time it took to sort 

        //constructor for to initialise the array
        public InsertionSort(int[] arr)
        {
            this.arr = arr;
        }

        //another constructor to initialise the array if the user inputs a list
        public InsertionSort(List<int> l)
        {
            this.arr = l.ToArray();
        }

        public int[] Sort()
        {

            Stopwatch sw = Stopwatch.StartNew(); // creates an stopwatch object
            // Start the stopwatch to measure the sorting time
            sw.Start();

            // Loop through the array starting from the second element
            for (int i = 1; i < arr.Length; i++)
            {
                // Store the current element as the key
                int key = arr[i];
                // Initialize j to the index of the previous element
                int j = i - 1;

                // Move elements that are greater than the key to one position ahead of their current position
                while (j >= 0 && key < arr[j])
                {
                    arr[j + 1] = arr[j]; // Shift element to the right
                    j--; // Move to the previous element
                }

                // Place the key in its correct position
                arr[j + 1] = key;
            }

            // Stop the stopwatch after sorting is complete
            sw.Stop();
            sortTime = sw.Elapsed.TotalNanoseconds;
            sw.Reset();

            // Return the sorted array
            return arr;
        }


        public void PrintNums()
        {
            Console.WriteLine(String.Join(", ", arr));
            

        }

    }
}
