using System;
using System.Collections.Generic;
using System.Text;

namespace MYComputerScience
{
    class SelectionSort
    {
    
        public void selectionSort()
        {
            int n = 10;
            int[] arr = new int[n];
            int cache;

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(0, 10);
                Console.Write("{0}:", arr[i]);

            }
            
            Console.WriteLine();

            for (int k = 0; k < arr.Length-1; k++)
            {
                cache = k;
                for (int j = k+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[cache])
                        cache = j;
                }
                int tmp = arr[k];
                arr[k] = arr[cache];
                arr[cache] = tmp;
            }

            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write("{0}:", arr[z]);
            }


        }

    }
}
