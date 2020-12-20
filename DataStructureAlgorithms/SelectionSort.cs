using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class SelectionSort
    {

        public static void Sort(int[] arr)
        {
            int counter = 0;
            int minimumIndex = counter;
            int traversingIndex = counter + 1;

            while(counter < arr.Length)
            {
                for(int i = counter; i < arr.Length-1; i++)
                {
                    if(arr[i] > arr[traversingIndex])
                    {
                        minimumIndex = traversingIndex;
                    }
                    traversingIndex++;
                }
                int temp = arr[counter];
                int temp2 = arr[minimumIndex];
                arr[minimumIndex] = temp;
                arr[counter] = temp2;

                counter++;
                minimumIndex = counter;
                traversingIndex = counter + 1;
            }
        }
    }
}
