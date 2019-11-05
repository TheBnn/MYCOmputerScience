using System;
using System.Collections.Generic;
using System.Text;

namespace MYComputerScience
{
    public class BubbleSort
    {

        public void sort()
        {
            int n = 100;
            int[] arr = new int[n];
            int cache;

            Random r = new Random();
               
            for(int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
                Console.Write("{0}:",arr[i]);

            }

            Console.WriteLine();
                    
            for (int j = 0; j < arr.Length; j++)
            {
                for (int k = 0; k < arr.Length-1-j; k++)
                {
                    if (arr[k] > arr[k + 1])
                    {
                        cache = arr[k];
                        arr[k] = arr[k + 1];
                        arr[k + 1] = cache;
                    }
                }
            }

            for (int z = 0; z < arr.Length; z++)
            {
                Console.Write("{0}:", arr[z]);
            }

        }

    }
}
