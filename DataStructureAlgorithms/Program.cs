using System;
using System.Collections.Generic;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data Structures

            //Array
            //string[] arr = {"Joshua", "Pakilit", "Lopez" };
            //Array<string>.PrintElementsInArray(arr);

            //List
            //List<int> randomInts = List_.RandomIntList(1, 10, 5);
            //string randInts = "";
            //foreach (int integer in randomInts)
            //{
            //    randInts += integer.ToString() + ' ';
            //}
            //Console.WriteLine(randInts);

            //LinkedList
            //LinkedList_<int> myLinkedList = new LinkedList_<int>(1);
            //myLinkedList.AddToEnd(23);
            //myLinkedList.AddToEnd(14);
            //myLinkedList.PrintValuesInLinkedList();

            //Queue
            //Queue<string> queue = new Queue<string>();
            //string[] arr = { "Joshua", "Pakilit", "Lopez" };
            //Queue_<string>.AddMultiple(arr, queue);
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            //Stack
            //Stack<string> stack = new Stack<string>();
            //Stack_<string>.AddMutiple(arr, stack);
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Pop());

            //Sorting Algorithms

            //InsertionSort
            int[] arr = {10,4,2};
            //InsertionSort.Sort(arr);

            //foreach(int item in arr)
            //{
            //    Console.Write(item.ToString() + ' ');
            //}

            //SelectionSort
            //SelectionSort.Sort(arr);

            //foreach (int item in arr)
            //{
            //    Console.Write(item.ToString() + ' ');
            //}

            //QuickSort
            //QuickSort.Sort(arr);

            //foreach (int item in arr)
            //{
            //    Console.Write(item.ToString() + ' ');
            //}

            //Searching Algorithms
            Console.WriteLine(BinarySearch.Search(arr, 123));
        }
    }
}
