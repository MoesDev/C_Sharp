using System;

namespace first_csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Random rand = new Random();
            for (int val=0; val<5; val++)
            { 
                Console.WriteLine(rand.Next(2, 8));

            }
        }
    }
}
