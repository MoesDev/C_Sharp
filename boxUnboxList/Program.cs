using System;
using System.Collections.Generic;

/* BOX UNBOX LISTS
    Create an empty List of type object
    Add the following values to the list: 7, 28, -1, true, "chair"
    Loop through the list and print all values(Hint: Type Inference might help here!)
    Add all values that are Int type together and output the sum*/

namespace boxUnboxList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> listInfo = new List<object>();

            listInfo.Add(7);
            listInfo.Add(28);
            listInfo.Add(-1);
            listInfo.Add(true);
            listInfo.Add("chair");

            int sum =0;
            bool intExists = false;
            foreach(object info in listInfo)
            {
                if(info is string)
                {
                    Console.WriteLine((string)info);
                }
                else if (info is int)
                {
                    if (!intExists)
                    {
                        intExists = true;
                    }
                    sum = sum + (int)info;                    
                    Console.WriteLine((int)info);
                }
                else if (info is bool)
                {
                    Console.WriteLine((bool)info);
                }
                else
                {
                    Console.WriteLine("object type not read");
                }
            }
            if (intExists) {
                Console.WriteLine("The sum of the integers are: {0}", sum);
            }
            else
            {
                Console.WriteLine("There were no integers");
            }
            




        }
    }
}
