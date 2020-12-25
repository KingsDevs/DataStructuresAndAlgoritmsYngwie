using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class Array<T>
    {

        /* Initialize a method/function that takes an array as an argument then prints out the
          elements of the array 
         */
        
        public static void PrintElementsInArray(T[] arr)
        {
            foreach(T item in arr)
            {
                Console.Write(item.ToString() + ' ');
            }
            Console.WriteLine();
        }
    }
 }

 