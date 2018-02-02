using System;
using System.Collections.Generic;

/*Three Basic Arrays:
1-Create an array to hold integer values 0 through 9
2-Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
3-Create an array of length 10 that alternates between true and false values, starting with true*/

namespace CollectionsFundm2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1
            int[] numArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //OR

            int[] numArray2 = new int[10];
            int number = 0;
            foreach(int num in numArray2)
            {
                numArray2[num] = number;
                number++;
                Console.WriteLine(numArray2[num]);
            }

            //2
            string[] namesArray = { "Tim", "Martin", "Nikki", "Sara" };

            for(int val=0; val<namesArray.Length; val++)
            {
                Console.WriteLine(namesArray[val]);
            }

            //3
            bool[] trueFalseArray = new bool[10];
            bool boolValue = true;

            for(int indexVal=0; indexVal<trueFalseArray.Length; indexVal++)
            {
                trueFalseArray[indexVal] = boolValue;                
                if (boolValue)
                {
                    boolValue = false;
                }
                else
                {
                    boolValue = true;
                }
                Console.WriteLine("Index " + indexVal + " is " + trueFalseArray[indexVal]);

            }
            /*Multiplication Table
            4- With the values 1 - 10, use code to generate a multiplication table*/

            int[,] multiplyTable = new int[10, 10];
            int multiplier = 1;
            for(int row=0; row < 10; row++)
            {
                for(int index=0; index < 10; index++)
                {
                    multiplyTable[row, index] = (multiplier * (index + 1));
                    Console.Write(multiplyTable[row, index] + " ");
                }
                
                Console.WriteLine("this row is index " + row);
                multiplier++;
            }

            /*List of Flavors
             5- Create a list of Ice Cream flavors that holds at least 5 different flavors(feel free to add more than 5!)
                Output the length of this list after building it
                Output the third flavor in the list, then remove this value.
                Output the new length of the list(Note it should just be one less~)*/

            List<string> iceCream = new List<string>();

            iceCream.Add("Chocolate");
            iceCream.Add( "Vanilla");
            iceCream.Add("Strawberry");
            iceCream.Add("Rocky Road");
            iceCream.Add("Lavendar");

            Console.WriteLine("iceCream list length is {0}", iceCream.Count);
            Console.WriteLine("Third ice cream in list is {0}, removing this from the list", iceCream[2]);

            iceCream.Remove(iceCream[2]);

            Console.WriteLine("Third ice cream in list is now {0}", iceCream[2]);
            Console.WriteLine("New iceCream list length is {0}", iceCream.Count);

            /*User Info Dictionary
             6- Create a Dictionary that will store both string keys as well as string values
                For each name in the array of names you made previously, add it as a new key in this dictionary with value null
                For each name key, select a random flavor from the flavor list above and store it as the value
                Loop through the Dictionary and print out each user's name and their associated ice cream flavor.*/

            Dictionary<string, string> iceCreamPeople = new Dictionary<string, string>();
            int iceCreamIndex = 0;
            foreach(string person in namesArray)
            {
                if(iceCreamIndex >= iceCream.Count)
                {
                    iceCreamIndex = 0;
                }
                iceCreamPeople.Add(person, iceCream[iceCreamIndex]);
                iceCreamIndex++;
            }
            foreach(var entry in iceCreamPeople)
            {
                Console.WriteLine(entry.Key + " likes " + entry.Value);
            }
        }
    }
}
