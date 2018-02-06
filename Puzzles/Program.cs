using System;
using System.Collections.Generic;

namespace Puzzles
{
    class Program
    {
        public static int[] RandomArray()
        {
            int[] randomArr = new int[10];
            Random number = new Random();
            int max=5, min=25, sum=0;
            for(var index=0; index < randomArr.Length; index++)
            {
                randomArr[index] = number.Next(5, 25);
                if (randomArr[index] > max)
                {
                    max = randomArr[index];
                }
                if (randomArr[index] <min)
                {
                    min = randomArr[index];
                }
                sum += randomArr[index];
            }
            Console.WriteLine("The max is {0}, the min is {1}, and the sum of all values in the array is {2}", max, min, sum);
            return randomArr;
        }
        public static void PrintArray(int[] theArray)
        {
            Console.WriteLine("The array numbers are: ");
            foreach(int num in theArray)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine();
        }
        public static string TossCoin()
        {
            Random coinToss = new Random();
            string result;
            Console.WriteLine("Tossing a Coin!");
            if (coinToss.Next(1, 100)%2 == 0)
            {
                result = "Heads!";
            }
            else
            {
                result = "Tails!";
            }
            Console.WriteLine(result);
            return (result);
        }
        public static void TossMultipleCoins(int num)
        {
            Console.WriteLine("Multiple tosses start here... tossing coin {0} times!", num);
            int count = 1;
            int headsCount = 0;
            double headsRatio = 0.0;

            while(count <= num)
            {
                string headsOrTails = TossCoin();
                if(headsOrTails == "Heads!")
                {
                    headsCount++;
                }
                count++;
            }
            headsRatio = (double)headsCount / num;
            Console.WriteLine("There is a {1} ratio of Heads to total ({0}) coin tosses!", num, headsRatio);

        }
        public static void PrintNames(string[] theArray)
        {
            foreach(string name in theArray)
            {
                Console.Write(name + ", ");
            }
            Console.WriteLine();
        }
        public static void Shuffle(string[] arr)
        {
            int arrLength = arr.Length;
            Random randIndex = new Random();
            for (int index = 0; index < arrLength; index++)
            {
                Swap(arr, index, (index + randIndex.Next(arrLength - index)));
            }
        }
        public static void Swap(string[] arr, int a, int b)
        {
            string temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
        }
        public static string[] FiveOrMoreChar(string[] arr)
        {
            List<string> fivePlusCharNames = new List<string>();
            foreach(string name in arr)
            {
                int nameLength = name.Length;
                if(nameLength >= 5)
                {
                    fivePlusCharNames.Add(name);
                }
            }
            return fivePlusCharNames.ToArray();
        }
        static void Main(string[] args)
        {
            int[] rArray = RandomArray();
            PrintArray(rArray);
            TossCoin();
            TossMultipleCoins(5);
            string[] namesArray = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            PrintNames(namesArray);
            Shuffle(namesArray);
            PrintNames(namesArray);
            string[] fivePlus = FiveOrMoreChar(namesArray);
            Console.WriteLine("These are the names with 5 or more characters:");
            PrintNames(fivePlus);


        }
    }
}
