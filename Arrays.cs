using System;
using System.Collections.Generic;
using System.Text;

namespace Anya_Arrays
{
    class Arrays
    {
        public static int GetMinOfArray(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }

            return minValue;
        }

        public static int GetMaxOfArray(int[] array)
        {
            int maxValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }

            return maxValue;
        }

        public static int GetIndexOfMinValueOfArray(int[] array)
        {
            //Array.Sort(array);
            int minValue = array[0];
            int minIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            return minIndex;
        }

        public static int GetIndexOfMaxValueOfArray(int[] array)
        {
            //Array.Sort(array);
            int maxValue = array[0];
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
            }

            return maxIndex;
        }
    }
}



