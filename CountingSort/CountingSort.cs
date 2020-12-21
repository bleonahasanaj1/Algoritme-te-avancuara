using System;
using System.Collections.Generic;
using System.Text;

namespace CountingSort
{
    public class CountingSort
    {
        public int[] DistributionCountingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            int minValue = Min(array);
            int maxValue = Max(array);

            int[] counts = new int[maxValue - minValue + 1];

            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minValue]++;
            }

            //find distribution sum of counts array
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minValue]] = array[i];
                counts[array[i] - minValue]--;
            }

            return sortedArray;
        }

        public int[] ComparisionCountingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            int minValue = Min(array);
            int maxValue = Max(array);

            int[] counts = new int[array.Length];

            for (int i = 0; i < counts.Length - 1; i++)
            {
                for(int j = i+1; j < counts.Length; j++)
                {
                    if(array[i] < array[j])
                    {
                        counts[j]++;
                    }
                    else
                    {
                        counts[i]++;
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                sortedArray[counts[i]] = array[i];
            }

            return sortedArray;
        }

        private int Min(int[] array)
        {
            int minimum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minimum)
                {
                    minimum = array[i];
                }
            }
            return minimum;
        }

        private int Max(int[] array)
        {
            int maximum = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                }
            }

            return maximum;
        }
    }
}
