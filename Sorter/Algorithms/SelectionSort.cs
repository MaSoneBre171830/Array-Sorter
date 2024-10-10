using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public class SelectionSort
    {
        private int[] arr; //declares an array
        
        public double sortTime { get; private set; }
        

        //constructor for to initialise the array
        public SelectionSort(int[] arr)
        {
            this.arr = arr;
        }

        //another constructor to initialise the array if the user inputs a list
        public SelectionSort(List<int> l)
        {
            this.arr = l.ToArray();
        }

        public int[] Sort()
        {
            int temp;// declares the variable temp to use later to swap numbers
            int minIndex;// declaring the variable minIndex to store the index of the minimun number in the array

            Stopwatch sw = Stopwatch.StartNew(); // creates an stopwatch object 
            sw.Start(); //starts the stopwatch
            //go through loop
            for (int i = 0; i < arr.Length - 1; i++)
            {
                minIndex = i; // initialises the minIndex with the current minimun which is arr[i]

                
                for(int j = i + 1; j < arr.Length; j++)
                {   
                    //checks if the current minimun is bigger then arr[j]
                    if (arr[minIndex] > arr[j])
                        minIndex = j;//stores new current minimum index
                }

                //checks if the minimum number has changed to not swap if a number is in a correct place
                if (minIndex != i)
                {
                    //swap
                    temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                    
                }

            }
            sw.Stop(); // stops the stopwatch
            sortTime = sw.Elapsed.TotalNanoseconds; 
            sw.Reset(); // restarts the stopwatch

            //returns the sorted array
            return arr;
        }

        //prints the array and the elapsed time it took to sort the array
        public void PrintNums()
        {
            Console.WriteLine(String.Join(", ", arr));
            

        }
    }
}
