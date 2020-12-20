using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class BinarySearch
    {
        public static int Search(int[]arr, int target)
        {
            int r = arr.Length - 1;
            int l = 0;

            while(l <= r)
            {
                int mid = (l + r) / 2;
                
                if(arr[mid] == target)
                {
                    return mid;
                } else if(target < arr[mid])
                {
                    r = mid - 1;
                }
                else
                {
                    l = mid + 1;
                }
            }

            return -1;
        }
    }
}
