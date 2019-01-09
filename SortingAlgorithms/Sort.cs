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
        /// <returns></returns>
        public int[] Insertion(int[] values, bool asc = true)
        {
            for (int i = 0; i <= values.Length; i++)
            {
                int j = i - 1;

                // If ordering asc then check if greater than
                // Else check if value is less than
                while (j > 0 && (asc ? values[j - 1] > values[j] : values[j - 1] < values[j]))
                {
                    int temp = values[j];
                    values[j] = values[j - 1];
                    values[j - 1] = temp;
                    j--;
                }
            }
            
            return values;
        }
    }
}
