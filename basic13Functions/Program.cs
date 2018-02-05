using System;
using System.Collections.Generic;

namespace basic13Functions
{
    class Program
    {
        public static void Num1To255()
        {
            for (int num = 1; num <= 255; num++)
            {
                Console.WriteLine(num);
            }
        }
        public static void OddNum1To255()
        {
            for (int oddNum = 1; oddNum <= 255; oddNum = oddNum + 2)
            {
                Console.WriteLine(oddNum);
            }
        }
        public static void SumNum1To255()
        {
            int sum = 0;
            for (int num = 0; num <= 255; num++)
            {
                sum += num;
                Console.WriteLine("New number: {0} Sum: {1}", num, sum);
            }
        }
        public static void PrintArray(int[] theArray)
        {
            foreach (int number in theArray)
            {
                Console.WriteLine(number);
            }
        }
        public static void MaxNumArray(int[] theArray)
        {
            int maxNum = theArray[0];
            foreach (int number in theArray)
            {
                if (maxNum < number)
                {
                    maxNum = number;
                }
            }
            Console.WriteLine("The max number in this array is: {0}", maxNum);
        }
        public static void GetAverage(int[] theArray)
        {
            int average = 0;
            foreach(int number in theArray)
            {
                average += number;
            }
            average = average / theArray.Length;
            Console.WriteLine("The average of the numbers in this array is: {0}.", average);
        }
        public static int[] CreateOddArray(int startNum, int endNum)
        {
            if(startNum%2 == 0)
            {
                startNum++;
            }
            List<int> oddArray = new List<int>();
            while (startNum <= endNum)
            {
                oddArray.Add(startNum);
                startNum = startNum + 2;
            }
            return oddArray.ToArray();
        }
        public static void GreaterThanY(int[] theArray, int numberGreater)
        {
            int count = 0;
            foreach(int number in theArray)
            {
                if(number> numberGreater)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers in the array that are greater than {1}.", count, numberGreater);
        }
        public static void SquareTheValue(int[] theArray)
        {
            Console.WriteLine("The array values started as:");
            PrintArray(theArray);
            for(int indexNum =0; indexNum < theArray.Length; indexNum++)
            {
                theArray[indexNum] = theArray[indexNum] * theArray[indexNum];
            }
            Console.WriteLine("Then the array values were squared to:");
            PrintArray(theArray);

        }
        public static void EliminateNegative(int[] theArray)
        {
            for (int indexNum = 0; indexNum < theArray.Length; indexNum++)
            {
                if (theArray[indexNum] < 0)
                {
                    theArray[indexNum] = 0;
                }
            }
            Console.WriteLine("The new array is: ");
            PrintArray(theArray);
        }
        public static void MinNumArray(int[] theArray)
        {
            int minNum = theArray[0];
            foreach (int number in theArray)
            {
                if (minNum > number)
                {
                    minNum = number;
                }
            }
            Console.WriteLine("The min number in this array is: {0}", minNum);
        }
        public static void MaxMinAvg(int[] theArray)
        {
            MaxNumArray(theArray);
            MinNumArray(theArray);
            GetAverage(theArray);
        }
        public static void ShiftArray(int[] theArray)
        {
            Console.WriteLine("The array values started as:");
            PrintArray(theArray);
            for (int indexNum=0; indexNum < theArray.Length-1; indexNum++)
            {
                theArray[indexNum] = theArray[indexNum + 1];
            }
            theArray[theArray.Length - 1] = 0;
            Console.WriteLine("After the shift the array is:");
            PrintArray(theArray);
        }
        public static object[] NumberToString(int[] theArray)
        {
            int theLength = theArray.Length;
            object[] boxedArray = new object[theLength];
            for(int index=0; index < theLength; index++)
            {
                if (theArray[index] < 0)
                {
                    boxedArray[index] = "Dojo";
                }
                else
                {
                    boxedArray[index] = theArray[index];
                }
            }
            return boxedArray;
        }
        static void Main(string[] args)
        {
            int[] x = { 1, 3, 5, 7, 9, 13 };
            int[] y = { -7, -11, 9, 7 };
            int[] yy = { -7, -11, 9, 7 };
            int[] z = { 2, 3, 10 };
            int[] zz = { -1, -3, 2 };

            Num1To255();
            OddNum1To255();
            SumNum1To255();
            PrintArray(x);
            MaxNumArray(y);
            GetAverage(y);
            CreateOddArray(1, 255);
            //Console.WriteLine(CreateOddArray(2, 255)[0]);
            GreaterThanY(x, 3);
            SquareTheValue(z);
            EliminateNegative(y);
            MaxMinAvg(yy);
            MinNumArray(yy);
            ShiftArray(yy);
            Console.WriteLine("Replacing negative numbers with the word Dojo for array:");
            PrintArray(zz);
            Console.WriteLine("Should give us an object array:");
            Console.WriteLine(NumberToString(zz)[0]);
            Console.WriteLine(NumberToString(zz)[1]);
            Console.WriteLine(NumberToString(zz)[2]);



        }
    }
}
