using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class QuickSort
    {

        private static int Partition(int[] arr, int l, int r)
        {
            int pivot = arr[r];
            int i = l - 1;
            int temp = 0;

            for(int j = l; j < r; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            temp = arr[r];
            arr[r] = arr[i + 1];
            arr[i + 1] = temp;
            
            return i + 1;
        }

        private static void QS(int[] arr, int l, int r)
        {
            if(l >= r)
            {
                return;
            }

            int pivot = Partition(arr, l, r);
            
            QS(arr, l, pivot - 1);
            QS(arr, pivot + 1, r);
        }

        public static void Sort(int[] arr)
        {
            QS(arr, 0, arr.Length - 1);
        }
    }
}
