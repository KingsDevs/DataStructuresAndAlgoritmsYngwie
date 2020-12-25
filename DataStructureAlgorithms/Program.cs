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
            //string[] arr = { "Marc", "Lojane", "Yngwie", "Pasaylo", "Pakilit" };
            //Array<string>.PrintElementsInArray(arr);

            //int[] arr2 = RandomArr(0, 100, 10);
            //Array<int>.PrintElementsInArray(arr2);

            //char[] arr3 = { 'Y', 'N', 'G', 'W', 'I', 'E' };
            //Array<char>.PrintElementsInArray(arr3);

            //bool[] arr4 = { true, true, false, true, false };
            //Array<bool>.PrintElementsInArray(arr4);

            //List
            //List<int> myList = List_.RandomIntList(1, 1000, 20);

            //foreach (int item in myList)
            //{
            //    Console.Write(item.ToString() + ' ');
            //}


            //LinkedList
            //LinkedList_<int> myLinkedList = new LinkedList_<int>(1);
            //myLinkedList.AddToEnd(23);
            //myLinkedList.AddToEnd(14);
            //myLinkedList.PrintValuesInLinkedList();

            //Queue
            //Queue<string> myQueue = new Queue<string>();
            //string[] arr = { "Marc", "Lojane", "Yngwie", "Pasaylo", "Pakilit" };
            //Queue_<string>.AddMultiple(arr, myQueue);
            //int size = myQueue.Count;
            //for(int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(myQueue.Dequeue());
            //}


            //Stack
            //Stack<string> myStack = new Stack<string>();
            //string[] arr = { "Marc", "Lojane", "Yngwie", "Pasaylo", "Pakilit" };
            //Stack_<string>.AddMutiple(arr, myStack);
            //int size = myStack.Count;
            //for(int i = 0; i < size; i++)
            //{
            //    Console.WriteLine(myStack.Pop());
            //}

            //Sorting Algorithms

            //InsertionSort
            //int[] arr = RandomArr(0, 20, 10);
            //Console.Write("Original Array: ");
            //Array<int>.PrintElementsInArray(arr);
            //InsertionSort.Sort(arr);
            //Console.Write("Sorted Array: ");
            //Array<int>.PrintElementsInArray(arr);


            //SelectionSort
            //int[] arr = RandomArr(0, 20, 10);
            //Console.Write("Original Array: ");
            //Array<int>.PrintElementsInArray(arr);
            //SelectionSort.Sort(arr);
            //Console.Write("Sorted Array: ");
            //Array<int>.PrintElementsInArray(arr);



            //QuickSort
            //int[] arr = RandomArr(0, 20, 10);
            //Console.Write("Original Array: ");
            //Array<int>.PrintElementsInArray(arr);
            //QuickSort.Sort(arr);
            //Console.Write("Sorted Array: ");
            //Array<int>.PrintElementsInArray(arr);


            //Searching Algorithms
            int[] arr = RandomArr(0, 15, 10);
            int[] arr2 = RandomArr(0, 15, 10);
            int[] arr3 = RandomArr(0, 15, 10);
            Array<int>.PrintElementsInArray(arr);
            Console.WriteLine(BinarySearch.Search(arr, 10));
            Array<int>.PrintElementsInArray(arr2);
            Console.WriteLine(BinarySearch.Search(arr2, 14));
            Array<int>.PrintElementsInArray(arr3);
            Console.WriteLine(BinarySearch.Search(arr3, 40));
        }

        public static int[] RandomArr(int min, int max, int size)
        {
            int[] arr = new int[size];
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max + 1);
            }


            return arr;
        }
    }
}
