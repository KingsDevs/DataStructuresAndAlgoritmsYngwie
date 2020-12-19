using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class Array
    {
       

        /* Initialize a method/function that takes an array as an argument then prints out the
          elements of the array 
         */
        public static void PrintElementsInArray(int[] arr)
        {
            foreach(int items in arr)
            {
                Console.Write(items);
            }
        }

        }
    }

 