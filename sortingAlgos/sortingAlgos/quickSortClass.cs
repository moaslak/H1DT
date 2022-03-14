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

        public int[] quickSort(int[] array, int start, int end)
        {
            int pivot;
            
            
            if( start < end)
            {
                pivot = partition(array, start, end);
            }

            return array;
        }

        public string[] quickSort(string[] array, int start, int end)
        {
            string pivot;

            if(start < end)
            {
                pivot = partition(array, start, end);
            }
            return array;
        }

        private string partition(string[] array, int start, int end)
        {
            string pivot = array[end];
            int i = start - 1;

            for(int j = start; j <= end - 1; j++)
            {
                if(array[j].CompareTo(pivot) < 0)
                {
                    i++;
                    swap(array[i], array[j]);
                }
            }
            swap(array[i + 1], array[end]);
            return array[i + 1];
        }

        private int partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int i = start - 1;
            for (int j = start; j <= end - 1; j++)
            {
                if (array[j] < pivot)
                {
                    i++;
                    swap(array[i], array[j]);
                }
            }
            swap(array[i + 1], array[end]);
            return (i + 1);
        }

        private void swap(int a, int b)
        {
            int buffer = b;
            b = a;
            a = buffer;
        }

        private void swap(string a, string b)
        {
            string buffer = b;
            b = a;
            a = buffer;
        }
    }
}
