using System;

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
        public int[] Insertion(int[] values)
        {
            for (int i = 0; i <= values.Length; i++)
            {
                int j = i - 1;

                while (j > 0 && (values[j - 1] > values[j]))
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
        public int[] Selection(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                int min = i;

                for (int j = i + 1; j < values.Length; j++)
                {
                    if (values[j] < values[min])
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
        /// Sorts numbers using merge sort algorithm 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public int[] Merge(int[] values)
        {
            if (values.Length <= 1)
                return values;

            int[] left = new int[values.Length / 2];
            int[] right = new int[values.Length % 2 == 0 ? values.Length / 2 : values.Length / 2 + 1];

            int lIndex = 0;
            int rIndex = 0;

            for (int i = 0; i < values.Length; i++)
            {
                if (i < values.Length / 2)
                {
                    left[lIndex++] = values[i];
                }
                else
                {
                    right[rIndex++] = values[i];
                }
            }

            left = Merge(left);
            right = Merge(right);

            return MergeArrays(left, right);
        }

        /// <summary>
        /// Combines two arrays into one
        /// </summary>
        /// <param name="left"></param>
        /// <param name="right"></param>
        /// <returns></returns>
        int[] MergeArrays(int[] left, int[] right)
        {
            int[] results = new int[left.Length + right.Length];

            int i = 0;
            int lIndex = 0;
            int rIndex = 0;

            while (lIndex < left.Length && rIndex < right.Length)
            {
                if (left[lIndex] <= right[rIndex])
                {
                    results[i++] = left[lIndex++];
                }
                else
                {
                    results[i++] = right[rIndex++];
                }
            }

            while (lIndex < left.Length)
            {
                results[i++] = left[lIndex++];
            }

            while (rIndex < right.Length)
            {
                results[i++] = right[rIndex++];
            }

            return results;
        }

        public int[] Reverse(int[] values)
        {
            int[] results = new int[values.Length];
            int i = values.Length - 1;
            int index = 0;

            while (i >= 0)
            {
                results[index++] = values[i--];
            }

            return results;
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
