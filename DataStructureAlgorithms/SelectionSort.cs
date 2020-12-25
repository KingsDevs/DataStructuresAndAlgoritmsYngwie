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
            int temp = 0;

            while(counter < arr.Length)
            {
                for(int i = counter; i < arr.Length-1; i++)
                {
                    if(arr[minimumIndex] > arr[traversingIndex])
                    {
                        minimumIndex = traversingIndex;
                    }
                    traversingIndex++;
                }
                temp = arr[counter];
            
                arr[counter] = arr[minimumIndex];
                arr[minimumIndex] = temp;
                

                counter++;
                minimumIndex = counter;
                traversingIndex = counter + 1;
            }
        }
    }
}
