using System;
using System.Collections.Generic;
using System.Text;

namespace BlaxZoser.Algorithm
{
    public class Find
    {


        /// <summary>
        /// k largest(or smallest) elements in an array | added Min Heap method
        /// </summary>
        /// <param name="array">disorden Array</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetNumberSmallestByIndex(int[] array, int index)
        {
            // Method 1(Use Bubble k times)
            // 1) Modify Bubble Sort to run the outer loop at most k times.
            // 2) Print the last k elements of the array obtained in step 1.
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array[index];
        }

        /// <summary>
        /// k largest(or smallest) elements in an array | added Min Heap method
        /// </summary>
        /// <param name="array">disorden Array</param>
        /// <param name="index"></param>
        /// <returns></returns>
        public int GetNumberLargestByIndex(int[] array, int index)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        var temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            return array[index];
        }


        public int[] GetRepeatNumber(int[] array, int index)
        {
            int i, j, x=0;
            var size = array.Length;
            int[] resultNumbers = new int[2];
            for (i = 0; i < size; i++)
            {
                for (j = i + 1; j < size; j++)
                {
                    if (array[i] == array[j])
                    {
                        resultNumbers[x] = array[i];
                        x++;
                    }                     
                }
            }

            return resultNumbers;

        }


        /// <summary>
        /// Find duplicates in O(n) time and O(1) extra space
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] GetRepeatNumberN(int[] array)
        {
            int i, x = 0;
            var size = array.Length;
            int[] resultNumbers = new int[size];


            for (i = 0; i < size; i++)
            {

                if (array[Math.Abs(array[i])] >= 0)
                    array[Math.Abs(array[i])] =
                        -array[Math.Abs(array[i])];
                else
                {
                    resultNumbers[x] = Math.Abs(array[i]);
                    x++;
                }
            }

            return resultNumbers;

        }
    }
}
