using System;
using System.Collections.Generic;
using System.Text;

namespace MYComputerScience.Sorts
{
    public class InsertionSort
    {
        public void insertionSort()
        {
            int n = 10;
            int[] arr = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(0, 10);
                Console.Write("{0}:", arr[i]);
            }

            Console.WriteLine();

            for (int j = 1; j < arr.Length; j++)
            {
                int key = arr[j];
                int l = j;

                while ((l > 0) && (arr[l-1] > key))
                {
                    arr[l] = arr[l-1];
                    l = l - 1;
                }
                arr[l] = key;
            }

            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write("{0}:", arr[z]);
            }


        }
    }
}
