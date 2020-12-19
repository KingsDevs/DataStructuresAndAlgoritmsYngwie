using System;
using System.Collections.Generic;

namespace DataStructureAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array
            //int[] arr = { 1, 2, 3 };
            //DataStructure.PrintElementsInArray(arr);

            //List
            //List<int> randomInts = List_.RandomIntList(1, 10, 5);
            //string randInts = "";
            //foreach (int integer in randomInts)
            //{
            //    randInts += integer.ToString() + ' ';
            //}
            //Console.WriteLine(randInts);

            //LinkedList
            LinkedList_<int> myLinkedList = new LinkedList_<int>(1);
            myLinkedList.AddToEnd(23);
            myLinkedList.AddToEnd(14);
            myLinkedList.PrintValuesInLinkedList();
            
        }
    }
}
