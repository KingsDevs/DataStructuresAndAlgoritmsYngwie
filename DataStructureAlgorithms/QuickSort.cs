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

            for(int j = l; j < r; j++)
            {
                if(arr[j] < pivot)
                {
                    i++;
                    int temp_ = arr[i];
                    int temp2_ = arr[j];
                    arr[i] = temp2_;
                    arr[j] = temp_;
                }
            }

            int temp = arr[r];
            int temp2 = arr[i + 1];

            arr[r] = temp2;
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
