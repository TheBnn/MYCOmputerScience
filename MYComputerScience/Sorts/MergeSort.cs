using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MYComputerScience.Sorts
{
    class MergeSort
    {
        static private int[] getArray()
        {
            int n = 10;
            int[] arr = new int[n];

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                arr[i] = r.Next(-10, 10);
                Console.Write("{0}:", arr[i]);
            }
            Console.WriteLine();

            return arr;
        }

        static private int[] merge(int[] left, int[] right)
        {

            //Сделать сортировку
            int[] result = left.Concat(right).ToArray();
            return result;
        }

        static public int[] mergeSort(int[] arr)
        {
            int[] right = new int[arr.Length];
            int[] left = new int[arr.Length];

            if (arr.Length <= 1)
                return arr;

            else { 
                int lengthArr = arr.Length;
                int middle = lengthArr / 2;

                int count = 0;
                foreach (var item in arr)
                {
                    count++;

                    if (middle == count)
                        break;

                    left[count] = item;

                    if (count <= arr.Length)
                        right[count] = item;
                    
                }
                //StackOverflow
                int[] l = mergeSort(left);
                int[] r = mergeSort(right);
                arr = merge(l, r);
                return arr;
            }
        }
    }
}
