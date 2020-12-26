using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class BinaryTree<T>
    {
        public T data;
        public BinaryTree<T> leftChild;
        public BinaryTree<T> rightChild;
        

        public BinaryTree(T _data)
        {
            data = _data;
            leftChild = null;
            rightChild = null;
        }

        public void AddToLeftEnd(T _data)
        {
            if(leftChild == null)
            {
                leftChild = new BinaryTree<T>(_data);
            }

            leftChild.AddToLeftEnd(_data);
        }

        public void AddtoRightEnd(T _data)
        {
            if (rightChild == null)
            {
                rightChild = new BinaryTree<T>(_data);
            }

            rightChild.AddtoRightEnd(_data);
        }
    }
}
