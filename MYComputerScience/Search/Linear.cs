using System;
using System.Collections.Generic;
using System.Text;

namespace MYComputerScience.Search
{
    class Linear
    {
        public void search()
        {

            int n = 10;
            int[] arr = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-100, 100);
                Console.Write("{0}:", arr[i]);
            }
            Console.WriteLine();
            int searchItem;
            if(Int32.TryParse(Console.ReadLine(), out searchItem)) { 
                for(int j = 0; j <arr.Length;j++)
                {
                       if(arr[j] == searchItem)
                        Console.WriteLine("pos -> {1}; el -> {0}", arr[j],j);
                }
            }
        }

    }
}
