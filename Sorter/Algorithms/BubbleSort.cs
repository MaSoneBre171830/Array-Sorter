using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Sorting_Algorithms
{
    public class BubbleSort
    {
        private int[] arr; //declares an array
        Stopwatch sw = new Stopwatch(); // creates an stopwatch object 

        public double sortTime { get; private set; }

        //constructor for to initialise the array
        public BubbleSort(int[] arr)
        {
            this.arr = arr;
            
        }

        //another constructor to initialise the array if the user inputs a list
        public BubbleSort(List<int> l)
        {
            this.arr = l.ToArray();
            
        }



        public int[] Sort()
        {
            int temp; // declares the variable temp to use later to swap numbers

            
            sw.Start();//starts the stopwatch
            //go through the array
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //check if number j is bigger then number j+1 if true then swap
                    if (arr[j] > arr[j + 1])
                    {
                        //swap
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;

                    }
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

        public int[] SortWithArraySort()
        {
            sw.Reset();
            sw.Start();
            // Directly sorts the array using Array.Sort
            Array.Sort(arr);
            sw.Stop();
            sortTime = sw.Elapsed.TotalNanoseconds;
            return arr;
        }
    }
}
