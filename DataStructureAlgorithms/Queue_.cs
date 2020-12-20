using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class Queue_<T>
    {
       // Add elements in array to Queue
       
        public static void AddMultiple(T[] arr, Queue<T> queue)
        {
            foreach(T item in arr)
            {
                queue.Enqueue(item);
            }
        }

       
    }
}
