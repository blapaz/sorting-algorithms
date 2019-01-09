using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms
{
    class Sort
    {
        /// <summary>
        /// Sorts numbers using insertion sort algorithm 
        /// </summary>
        /// <param name="values"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public int[] Insertion(int[] values, bool asc = true)
        {
            for (int i = 0; i <= values.Length; i++)
            {
                int j = i - 1;

                while (j > 0 && (asc ? values[j - 1] > values[j] : values[j - 1] < values[j]))
                {
                    Swap(values, j, j - 1);
                    j--;
                }
            }
            
            return values;
        }


        /// <summary>
        /// Sorts numbers using selection sort algorithm 
        /// </summary>
        /// <param name="values"></param>
        /// <param name="asc"></param>
        /// <returns></returns>
        public int[] Selection(int[] values, bool asc = true)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (asc ? values[j] < values[min] : values[j] > values[min])
                    {
                        min = j;
                    }
                }

                if (min != i)
                {
                    Swap(values, i, min);
                }
            }

            return values;
        }

        /// <summary>
        /// Swaps indexes of items in an array
        /// </summary>
        /// <param name="values"></param>
        /// <param name="index1"></param>
        /// <param name="index2"></param>
        /// <returns></returns>
        int[] Swap(int[] values, int index1, int index2)
        {
            int temp = values[index1];
            values[index1] = values[index2];
            values[index2] = temp;
            return values;
        }
    }
}
