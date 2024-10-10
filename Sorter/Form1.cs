using Sorting_Algorithms;
using System.Diagnostics;
using System.Windows.Forms;


namespace Sorter
{
    public partial class Form1 : Form
    {

        Random rn = new Random();
        int arrayLength;
        int[] array;
        int[] unsortedArray;

        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            comboBox1.SelectedIndex = 0;

            RunDummyQuickSort(); // runs the quick sort on the app startup to warm up the algorithm because the first sort always give wrong sorting times
        }

        private void button1_Click(object sender, EventArgs e)
        {

            arrayLength = rn.Next(10, 100); // Initializes the array length to a random int between 5 and 50
            array = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = rn.Next(100); // Fill the array with random numbers from 0 to 99
            }

            // Create a copy of the original unsorted array for resetting later
            unsortedArray = (int[])array.Clone();
            ReturnArray();

        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            array = textBox1.Text.Split(',').Select(int.Parse).ToArray();
            unsortedArray = (int[])array.Clone();

            label1.Text = "You can sort now!!!!";
        }


        private void SortNumbers_Click(object sender, EventArgs e)
        {
            SortNumber();
        }

        private void ReturnArray()
        {
            textBox1.Text = String.Join(",", array);
        }

        private void ReturnSortedArray()
        {
            label2.Text = String.Join(", ", array);
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.Title = "Select a File of Numbers";

                // Show the dialog and check if a file was selected
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Read all lines from the selected file
                    string filePath = openFileDialog.FileName;
                    string[] lines = System.IO.File.ReadAllLines(filePath);

                    // Convert the content to an integer array
                    try
                    {
                        // Assuming each line is a number or a comma-separated list of numbers
                        List<int> numbersList = new List<int>();

                        foreach (var line in lines)
                        {
                            // Split by commas, trim any spaces, and parse to integers
                            var numbers = line.Split(',').Select(n => int.Parse(n.Trim())).ToArray();
                            numbersList.AddRange(numbers);
                        }

                        // Store numbers in an array for use in the application
                        array = numbersList.ToArray();

                        // Display the numbers in the appropriate label or control
                        ReturnArray(); // This method updates the label or UI component with the array
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("The file contains invalid data. Please ensure it only has numbers separated by commas.", "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        // dont ask why this exist 💀
        private void RunDummyQuickSort()
        {
            int[] dummyArray = new int[] { 5, 2, 4, 1, 3 };
            QuickSort warmupSort = new QuickSort(dummyArray);
            warmupSort.Sort();
        }


        //sorts numbers depending on the user choice of algorithm
        private void SortNumber()
        {
            array = (int[])unsortedArray.Clone();

            switch (comboBox1.SelectedIndex)                                                                            // index 0 = Bubble sort; index 1 = Insertion sort; Index 2 = Selection sort;
            {
                case 0:
                    //Bubble sort
                    BubbleSort bubbleSort = new BubbleSort(array);
                    bubbleSort.Sort();
                    lbl_SortTime.Text = bubbleSort.sortTime.ToString();

                    break;
                case 1:
                    //Insertion sort
                    InsertionSort ionSort = new InsertionSort(array);
                    ionSort.Sort();
                    lbl_SortTime.Text = ionSort.sortTime.ToString();

                    break;
                case 2:
                    //Selection sort
                    SelectionSort selectionSort = new SelectionSort(array);
                    selectionSort.Sort();
                    lbl_SortTime.Text = selectionSort.sortTime.ToString();

                    break;
                case 3:
                    QuickSort quickSort = new QuickSort(array);
                    quickSort.Sort();
                    lbl_SortTime.Text = quickSort.sortTime.ToString();

                    break;
                case 4:
                    BubbleSort arrSort = new BubbleSort(array);
                    arrSort.SortWithArraySort();
                    lbl_SortTime.Text = arrSort.sortTime.ToString();

                    break;
            }

            ReturnSortedArray();
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            var statsForm = new Form2();
            
            statsForm.Show();
        }
    }
}
