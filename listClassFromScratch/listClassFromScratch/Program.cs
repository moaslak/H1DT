using System;

namespace listClassFromScratch
{
    class Program
    {
        static listClass listArray = new listClass();
        static int removeAt = 1;
        static int getAt = 2;
        static string contain = "8";
        /// <summary>
        /// Test programme for the listClass class. Input is MUST be converted to strings. 
        /// Functions are getSize(), addToList(), removeAt(), contains(),   
        /// Output is determined by whichever conversion method is called (int, double). 
        /// String will be returned if no conversion method is called.
        /// </summary>
        static void Main()
        {
            //Create test data
            Console.WriteLine("Create test data");
            string[] array = listArray.createArray(5);
            array[0] = "1";
            array[1] = "2";
            array[2] = "3";
            array[3] = "4";
            array[4] = "1";
            //array = listArray.addToList(array, "john");
            Console.WriteLine("Testdata: ");
            foreach (string s in array)
                Console.WriteLine(s);

            int[] arrayOfInts = listArray.stringArray2Int(array);
            
            //Remove duplets
            Console.WriteLine();
            Console.WriteLine("Remove duplets");
            foreach (string s in listArray.intArray2String(arrayOfInts))
                Console.WriteLine(s);

            //Get size
            Console.WriteLine();
            Console.WriteLine("Get size");
            Console.WriteLine(listArray.getSize(listArray.intArray2String(arrayOfInts)));

            //Add
            Console.WriteLine();
            Console.WriteLine("Add");
            Console.WriteLine("Adds " + contain);
            foreach(string s in listArray.addToList(listArray.intArray2String(arrayOfInts), contain))
                Console.WriteLine(s);
            
            //Remove
            Console.WriteLine();
            Console.WriteLine("Remove");
            Console.WriteLine("Removes at index: " + removeAt);
            foreach (string s in listArray.removeAtIndex(listArray.intArray2String(arrayOfInts), removeAt))
                Console.WriteLine(s);

            //Contains
            Console.WriteLine();
            Console.WriteLine("Contains");
            bool contains = listArray.contains(listArray.intArray2String(arrayOfInts), contain);
            Console.WriteLine("List contains '" + contain + "': " + contains);

            //At index
            Console.WriteLine();
            Console.WriteLine("At index");
            Console.WriteLine(listArray.getAt(listArray.intArray2String(arrayOfInts), getAt));

            //Convert to ints
            Console.WriteLine();
            Console.WriteLine("To int array");
            Console.WriteLine("Removes at: " + removeAt.ToString());
            foreach (int i in listArray.stringArray2Int(listArray.removeAtIndex(listArray.intArray2String(arrayOfInts), removeAt)))
                Console.WriteLine(i);

            //Using doubles
            Console.WriteLine();
            Console.WriteLine("Using doubles");
            array = listArray.addToList(array, "1.1");
            double[] arrayOfDoubles = listArray.stringArray2Double(array);
            foreach(double d in arrayOfDoubles)
                Console.WriteLine(d);

            /*Type type = typeof(string);
            listArray.objectArray2String(array,type.GetType());
            */
            Console.ReadKey();
        }
    }
}