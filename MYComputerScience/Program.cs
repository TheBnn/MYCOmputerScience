using MYComputerScience.Sorts;
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


            Console.WriteLine("Bubble Sort");
           // bubble.sort();

            Console.WriteLine("Selection Sort");
            //selection.selectionSort();

            Console.WriteLine("Insertion Sort");
            insertion.insertionSort();


        }
    }
}
