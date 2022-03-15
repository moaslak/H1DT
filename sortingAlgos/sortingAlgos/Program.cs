using System;

namespace sortingAlgos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] testArray = new int[100]; 
            int[] sortedArray = new int[10];
            quickSortClass quickSort = new quickSortClass();

            for(int i = 0; i < testArray.Length; i++)
            {
                testArray[i] = random.Next(0,500);
            }

            Console.WriteLine("Before sort");
            foreach (int i in testArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            quickSort.quickSort(testArray, 0, testArray.Length-1);
            //sortedArray = quickSort.bubbleSort(testArray);
            Console.WriteLine("after sort");
            foreach (int i in testArray)
            {
                Console.WriteLine(i);
            }
            
            Console.ReadKey();
        }
    }
}