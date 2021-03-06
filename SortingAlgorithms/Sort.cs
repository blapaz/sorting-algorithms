﻿using System;

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
        public static int[] Insertion(int[] values)
        {
            for (int i = 0; i <= values.Length; i++)
            {
                int j = i - 1;

                while (j > 0 && (values[j - 1] > values[j]))
                {
                    values = Swap(values, j, j - 1);
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
        public static int[] Selection(int[] values)
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
                    values = Swap(values, i, min);
                }
            }

            return values;
        }

        /// <summary>
        /// Sorts numbers using merge sort algorithm 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int[] Merge(int[] values)
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
        static int[] MergeArrays(int[] left, int[] right)
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

        /// <summary>
        /// Sorts numbers using bubble sort algorithm 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int[] Bubble(int[] values)
        {
            for (int i = 0; i < values.Length - 1; i++)
            {
                for (int j = 0; j < values.Length - i - 1; j++)
                {
                    if (values[j] > values[j + 1])
                    {
                        values = Swap(values, j, j + 1);
                    }
                }
            }

            return values;
        }

        /// <summary>
        /// Sorts numbers using comb sort algorithm 
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int[] Comb(int[] values)
        {
            int gap = values.Length;
            bool isSorted = false;

            while (!isSorted)
            {
                gap = gap * 10 / 13;

                if (gap <= 1)
                {
                    isSorted = true;
                }

                int i = 0;

                while (i + gap < values.Length)
                {
                    if (values[i] > values[i + gap])
                    {
                        values = Swap(values, i, i + gap);
                    }

                    i++;
                }

            }

            return values;
        }

        /// <summary>
        /// Swaps values of array to be in reverse
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        public static int[] Reverse(int[] values)
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
        static int[] Swap(int[] values, int index1, int index2)
        {
            int temp = values[index1];
            values[index1] = values[index2];
            values[index2] = temp;
            return values;
        }

    }
}
