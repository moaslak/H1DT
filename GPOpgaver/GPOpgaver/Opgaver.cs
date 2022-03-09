using System;
using System.Collections.Generic;
using System.Text;


namespace GPOpgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Make an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        public static void Interchange(ref int x, ref int y)
        {
            int buffer = x;
            x = y;
            y = buffer;
            // minimum 3 assignments
        }
        /*
        * Introduktion til Algoritmer
        * Exercise 2. 
        * Make an algorithm that uses only assignment statements to replace thevalues of the triple(x, y, z) with (z, x, y).
        * What is the minimum number of assignment statements needed?
        */
        public static void InterchangeTriple(ref int x, ref int y, ref int z)
        {
            int buffer = z;
            z = y;
            y = x;
            x = buffer;
            // minimum 4 assignments.
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Make an algorithm for determining whether a string of n characters is a palindrome and output true or false.
         */
        public static bool IsPalindrome(string s)
        {
            int size = s.Length;
            char[] chars = s.ToCharArray();
            bool sameChar = true;
            for(int i = 0; i < s.Length; i++)
            {
                if(chars[i] == chars[size-1])
                {
                    sameChar = true;
                }
                else
                {
                    return false;
                }
                size--;
            }
            return sameChar;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         * The solution should return the number of steps that it goes through to complete the unit test
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            int steps = 1;
            while(searchFor != intergerArray[steps-1])
            {
                steps++;
            }
            return steps;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.b.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4B
         * The solution should return the number of steps that it goes through complete the unit test
         */
        public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
        {
            int steps = 1;
            int avg = (arrayEnd + arrayStart) / 2;

            while (!(integerArray[arrayStart] == searchFor || integerArray[arrayEnd] == searchFor))
            {
                avg = (arrayEnd + arrayStart) / 2;
                if (integerArray[avg] == searchFor)
                {
                    return steps;
                }
                else if (searchFor < integerArray[avg])
                {
                    arrayEnd = avg - 1;
                }
                else
                    arrayStart = avg+1;
                steps++;
            }

            
            
            return steps;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            int steps = 1;
            while (insert > sortedList[steps - 1])
            {
                steps++;
                if(insert < sortedList[steps])
                {
                    return steps;
                }     
            }
            return steps;
        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiplesArray = new int[length];
            for(int i = 1; i < length+1; i++)
            {
                multiplesArray[i-1] = num*i;
            }
            return multiplesArray;
        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            throw new NotImplementedException();
            //Write your solution here

        }
        /*
         * Exercise 8.
         * Create a Fact method that receives a non-negative integer and returns the factorial of that number.
         * Consider that 0! = 1.
         * You should return a long data type number.
         * https://www.mathsisfun.com/numbers/factorial.html
         */
        public static long Factorial(int n)
        {
            long factOut = 1;
            for(int i = 1; i < n+1; i++)
            {
                factOut = factOut*i;
            }
            return factOut;
        }
        /*
         * Exercise 9.
         * Write a function which increments a string to create a new string.
         * If the string ends with a number, the number should be incremented by 1.
         * If the string doesn't end with a number, 1 should be added to the new string.
         * If the number has leading zeros, the amount of digits should be considered.
         * exampel: 
         * wow0849 -> wow0850
         * test99 -> test100
         */
        public static string IncrementString(string txt)
        {           
            char[] chars = txt.ToCharArray();

            List<string> strings = new List<string>();
            List<int> numbers = new List<int>();
            List<string> numbersAsString = new List<string>();
            int zeroPad = 0;
            int incNumber = 0;
            bool paddingDone = false;
            string num2String = "";

            for(int i = 0; i < chars.Length; i++)
            {
                if (Char.IsLetter(chars[i]))
                {
                    strings.Add(chars[i].ToString());
                }
                else
                {
                    if(chars[i] == '0' && !paddingDone)
                    {
                        numbersAsString.Add(chars[i].ToString());
                        zeroPad++;
                    }
                    else
                    {
                        numbersAsString.Add(chars[i].ToString());
                        paddingDone = true;
                    }
                }
            }
            for(int i = 0; i < numbersAsString.Count; i++)
            {
                numbers.Add(Convert.ToInt32(numbersAsString[i]));
            }
            
            if (numbers.Count == 0)
                incNumber = 1;
            if(numbers.Count > 0)
            {
                for(int i = 0; i < numbers.Count; i++)
                {
                    incNumber = (incNumber * 10) + numbers[i];
                }
                incNumber++;
            }
            
            //string builder
            for (int i = 0; i < strings.Count; i++)
            {
                num2String = num2String + strings[i];
            }
            if (incNumber.ToString().Length == numbers.Count)
                zeroPad--;

            if (zeroPad > 0)
            {

                for (int i = 0; i < zeroPad; i++)
                {
                    num2String = num2String + "0";
                }
                
            }
            
            num2String = num2String + incNumber.ToString();

            return num2String;
            
        }
        /*
         * Exercise 10.
         * Write a method to validate a sercure password.
         *     The password must contain at least one uppercase character.
         *     The password must contain at least one lowercase character.
         *     The password must contain at least one number.
         *     The password must contain at least one special character 
         *     The password must not contain other special characters then ! @ # $ % ^ & * ( ) + = - { } [ ] : ; " ' ? < > , . _
         *     The password must be at least 8 characters in length.
         *     The password must not be 25 characters or over in length.
         */
        public static bool ValidatePassword(string password)
        {
            bool strongPassword = false;
            const int minLength = 8;
            const int maxLength = 25;
            char[] chars = password.ToCharArray();
            bool upperOk = false;
            bool lowerOk = false;
            bool digitOk = false;
            bool specialCharacterOk = false;
            bool lengthOk = false;
            string specialCharacters = @"!@#$%^&*()+=-{}[]:;'?<>,._" + '"';
            if (password.Length < minLength || password.Length > maxLength)
            {
                lengthOk = true;
            }
            
            for(int i = 0; i < chars.Length; i++)
            {
                if (Char.IsUpper(chars[i]))
                {
                    upperOk = true;
                }
                if (Char.IsLower(chars[i]))
                {
                    lowerOk = true;
                }
                if (Char.IsDigit(chars[i]))
                {
                    digitOk = true;
                }
                if(!(Char.IsLetter(chars[i])))
                {
                    foreach(char c in specialCharacters)
                    {
                        if (chars[i] == c)
                            specialCharacterOk = true;
                    }
                }
            }
            if(lengthOk && upperOk && lowerOk && digitOk && specialCharacterOk)
                strongPassword = true;
            return strongPassword;
        }
    }
}