using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class Stack_<T>
    {
        public static void AddMutiple(T[] arr, Stack<T> stack)
        {
            foreach(T item in arr)
            {
                stack.Push(item);
            }
        }
    }
}
