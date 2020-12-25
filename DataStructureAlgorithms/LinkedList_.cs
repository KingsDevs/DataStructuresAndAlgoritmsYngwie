using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class LinkedList_<T>
    {
        T data;
        public LinkedList_<T> pointer;
        public LinkedList_(T _data)
        {
            data = _data;
            pointer = null;
        }

        public void AddToEnd(T data)
        {
            if (pointer == null)
            {
                pointer = new LinkedList_<T>(data);
            }
            else
            {
                pointer.AddToEnd(data);
            }
        }

        public void PrintValuesInLinkedList()
        {
            Console.Write(data + "--> ");
            if(pointer != null)
            {
                pointer.PrintValuesInLinkedList();
            }
        }
    }
}
