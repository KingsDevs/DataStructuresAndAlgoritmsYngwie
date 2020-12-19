using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAlgorithms
{
    public class List_
    {

        /* Initialize a method/function that will return a random list of integers. The method takes 3 arguments
         * 1. The minimum integer
         * 2. The maximum integer
         * 3. The size of the list
         */

        public static List<int> RandomIntList(int min, int max, int size)
        {
            List<int> randomInts = new List<int>();
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                int value = random.Next(min, max + 1);
                randomInts.Add(value);
            }

            return randomInts;
        }
    }
}
