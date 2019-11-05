using System;


namespace MYComputerScience
{
     
    class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubble = new BubbleSort();
            SelectionSort selection = new SelectionSort();



            Console.WriteLine("Bubble Sort");
           // bubble.sort();

            Console.WriteLine("Selection Sort");
            selection.selectionSort();


        }
    }
}
