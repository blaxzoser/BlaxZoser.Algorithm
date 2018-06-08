using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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


        public int GetRepeatPattern(List<String> wordList, string pattern)
        {
            return  wordList.GroupBy(i => i)
                        .Select(i => new { Word = i.Key, Count = i.Count() })
                        .FirstOrDefault( s => s.Word == pattern)
                        .Count;
          
               
        }

        //Count the number of Duplicates
        //Write a function that will return the count of distinct case-insensitive 
        //alphabetic characters and numeric digits that occur more than once in 
        //the input string. The input string can be assumed to contain 
        //only alphabets(both uppercase and lowercase) and numeric digits.
        //Example
        //"abcde" -> 0 # no characters repeats more than once
        //"aabbcde" -> 2 # 'a' and 'b'
        //"aabBcde" -> 2 # 'a' occurs twice and 'b' twice (bandB)
        //"indivisibility" -> 1 # 'i' occurs six times
        //"Indivisibilities" -> 2 # 'i' occurs seven times and 's' occurs twice
        //"aA11" -> 2 # 'a' and '1'
        //"ABBA" -> 2 # 'A' and 'B' each occur twice
        public  int DuplicateCountUseLinq(string list)
        {
            return list.ToLower().GroupBy(c => c).Where(g => g.Count() > 1).Count();
        }

        public int[] MoveZerosToTheEnd(int[] arr)
        {
            int[] cleanNumbers = new int[arr.Length]; //Note: we counting without zero 
            var x = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != 0)
                {
                    cleanNumbers[x] = arr[i];
                    x++;
                }
            }                               
            return cleanNumbers;
        }

        public int[] MoveZerosToTheEndLambdas(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

    }
}
