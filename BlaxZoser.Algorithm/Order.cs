using System;
using System.Collections.Generic;
using System.Text;

namespace BlaxZoser.Algorithm
{
    public class Order
    {
        public int[] ApplyOrderAscWithBubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }

                }
            }
            return array;
        }

        public void ApplyRecursiveBubbleSort(int[] array,int n)
        {
            if (n == 1)
                return;
            for (int i = 0; i < array.Length  - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                }
                ApplyRecursiveBubbleSort(array, n - 1);
            }

        }

    }
}
