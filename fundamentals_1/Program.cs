using System;

namespace fundamentals_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
//1. Create a Loop that prints all values from 1-255
            for(int val=1; val<=255; val++){
                Console.WriteLine(val);
            }

//2. Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for(int val=1; val<=100; val++){
                if(((val%3 == 0) && (val%5 != 0))||((val%5 == 0) && (val%3 != 0))){ 
                    Console.WriteLine(val);
                }
                else{
                    continue;
                }                
            }
//3. Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            for(int val=1; val<=100; val++){

                if((val%3 == 0)||(val%5 == 0)){
                    string word="";
                    if(val%3 == 0){ word="Fizz";}
                    if(val%5 == 0){ word= word+"Buzz";}
                    Console.WriteLine(word);
                }
            }
//4. (Optional) If you used modulus in the last step, try doing the same without using it. Vice-versa for those who didn't!
            for(double val=1; val <=100; val++){
                double threeDivRemainder = (val - (3 * Math.Floor(val/3)));
                double fiveDivRemainder = (val - (5 * Math.Floor(val/5)));

                if((threeDivRemainder == 0)||(fiveDivRemainder == 0)){
                    string word="";
                    if(threeDivRemainder == 0){ word="Fizz";}
                    if(fiveDivRemainder == 0){ word= word+"Buzz";}
                    Console.WriteLine(word);
                }
}
//5. (Optional) Generate 10 random values and output the respective word, in relation to step three, for the generated values
            int count= 0;
            Random randVal = new Random();
            while(count<10){
                int testVal = randVal.Next();
                Console.WriteLine(testVal);
                if((testVal%3 == 0)||(testVal%5 == 0)){
                    string word="";
                    //For testing purposes
                    Console.WriteLine(testVal);
                    if(testVal%3 == 0){ word="Fizz";}
                    if(testVal%5 == 0){ word= word+"Buzz";}
                    Console.WriteLine(word);
                }
                count++;
            }

        }
    }
}

