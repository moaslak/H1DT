using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingAlgos
{
    public class quickSortClass
    {
        public int[] testData(int size)
        {
            Random random = new Random();
            int[] testData = new int[size];
            for(int i = 0; i < testData.Length; i++)
            {
                testData[i] = random.Next(0,10000);
            }
            return testData;
        }

        /// <summary>
        /// Homemade bubble sort. Sorts an int array.
        /// </summary>
        /// <param name="intArray"></param>
        /// <returns>int array</returns>
        public int[] bubbleSort(int[] intArray)
        {
            int buffer = 0;
            
            for(int i = 0; i < intArray.Length - 1; i++)
            { 
                for(int j = 0; j < intArray.Length - i-1; j++)
                {
                    if(intArray[j] > intArray[j + 1])
                    {
                        buffer = intArray[j];
                        intArray[j] = intArray[j + 1];
                        intArray[j+1] = buffer;
                    }    
                } 
            }
            return intArray;
        }
        /// <summary>
        /// Quicksort algorithm. Arguments, int array to sort. Start index and end index.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>sorted int array</returns>
        public int[] quickSort(int[] intArray, int start, int end)
        {
            int pivot;
            if (start < end)
            {
                pivot = subArray(intArray, start, end);
                if (pivot > 1)
                {
                    quickSort(intArray, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    quickSort(intArray, pivot + 1, end);
                }
            }
            return intArray;
        }

        /// <summary>
        /// Method for partitioning the array in quickSort(). Returns the pivot.
        /// </summary>
        /// <param name="intArray"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns>int</returns>
        private int subArray(int[] intArray, int start, int end)
        {
            int pivot = intArray[end];

            do
            {
                while (intArray[start] < pivot)
                {
                    start++;
                }
                while (intArray[end] > pivot)
                {
                    end--;
                }
                if (start < end)
                {
                    if (intArray[start] == intArray[end]) return end;
                    
                    int temp = intArray[end];
                    intArray[end] = intArray[start];
                    intArray[start] = temp;
                }
                else
                {
                    return end;
                }
            } while (true);
        }

        /*
        public string[] quickSort(string[] stringArray, int start, int end)
        {
            int pivot;
            if (start < end)
            {
                pivot = subArray(stringArray, start, end);
                if (pivot > 1)
                {
                    quickSort(stringArray, start, pivot - 1);
                }
                if (pivot + 1 < end)
                {
                    quickSort(stringArray, pivot + 1, end);
                }
            }
            return stringArray;
        }
        */
        public string[] bubbleSort(string[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = 0; j < Array.Length - 1; j++)
                {
                    if (Array[j].CompareTo(Array[j + 1]) > 0)
                    {
                        string temp = Array[j];
                        Array[j] = Array[j + 1];
                        Array[j + 1] = temp;
                    }
                }
            }
            return Array;
        }
        

        private int string2IntValue(string s)
        {
            char[] chars = s.ToCharArray();
            int output = 0;
            foreach(char c in chars)
                output = output + Convert.ToInt32(c);
            return output;
        }
    }
}
