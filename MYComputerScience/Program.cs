using MYComputerScience.Sorts;
using MYComputerScience.Search;
using System;


namespace MYComputerScience
{
     
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            SelectionSort selection = new SelectionSort();
            InsertionSort insertion = new InsertionSort();
            MergeSort merge = new MergeSort();
            Linear linear = new Linear();

            //Console.WriteLine("Bubble Sort");
            // bubble.sort();

            //Console.WriteLine("Selection Sort");
            //selection.selectionSort();

            //Console.WriteLine("Insertion Sort");
            //insertion.insertionSort();


            //Console.WriteLine("Merge Sort");
            //Console.WriteLine(MergeSort.mergeSort(arr));

            Console.WriteLine("Linear search");
            linear.search();

        }
    }
}
