using ScottPlot;
using Sorting_Algorithms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorter
{
    public partial class Form2 : Form
    {
        double[] AvrgSortTime = new double[5];                              // 0 = Selection sort; 1 = Insertion sort; 2 = Bubble sort; 3 = Quick sort; 4 = Array.Sort;
        public Form2()
        {
            InitializeComponent();

            // saves average sorting time of each algorithm 

        }

        private void SortForStats()
        {
            int testCount = 10; // Number of tests to run
            Random rnd = new Random();
            double[] sortTimeSum = { 0, 0, 0, 0, 0 };

            for (int i = 0; i < testCount; i++)
            {
                // Generate a random size for the array between 100 and 10000
                int arraySize = rnd.Next(100, 10001); // Random size between 100 and 10000

                // Generate a random array
                int[] randomArray = GenerateRandomArray(arraySize);

                // Test Selection Sort
                SelectionSort selectionSort = new SelectionSort((int[])randomArray.Clone());
                selectionSort.Sort();
                sortTimeSum[0] += selectionSort.sortTime / 1_000_000; // Convert nanoseconds to milliseconds

                // Test Insertion Sort
                InsertionSort insertionSort = new InsertionSort((int[])randomArray.Clone());
                insertionSort.Sort();
                sortTimeSum[1] += insertionSort.sortTime / 1_000_000;

                // Test Bubble Sort
                BubbleSort bubbleSort = new BubbleSort((int[])randomArray.Clone());
                bubbleSort.Sort();
                sortTimeSum[2] += bubbleSort.sortTime / 1_000_000;

                // Test Quick Sort
                QuickSort quickSort = new QuickSort((int[])randomArray.Clone());
                quickSort.Sort();
                sortTimeSum[3] += quickSort.sortTime / 1_000_000;

                // Test Array.Sort with BubbleSort class
                BubbleSort bubbleSortWithArraySort = new BubbleSort((int[])randomArray.Clone());
                bubbleSortWithArraySort.SortWithArraySort();
                sortTimeSum[4] += bubbleSortWithArraySort.sortTime / 1_000_000;


            }

            for (int i = 0; i < sortTimeSum.Length; i++)
            {
                AvrgSortTime[i] = sortTimeSum[i] / testCount;
            }
        }

        private static int[] GenerateRandomArray(int size)
        {
            Random rnd = new Random();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = rnd.Next(0, 10000); // Random numbers between 0 and 9999
            }
            return array;
        }

        private void btn_Stats_Click(object sender, EventArgs e)
        {
            SortForStats();

            string[] algo = { "Selection", " Insertion", "Bubble", "Quick", "Array.Sort" };
            int counter = 0;

            var barPlot = formsPlot1.Plot.Add.Bars(AvrgSortTime);
            foreach (var bar in barPlot.Bars)
            {
                bar.Label = algo[counter] + " " + Math.Round(bar.Value, 2).ToString();
                counter++;
            }
            //formsPlot1.Plot.Add.Scatter(dataArrayLength, y);
            formsPlot1.Plot.Axes.Margins(bottom: 0);
            formsPlot1.Refresh();
        }
    }
}
