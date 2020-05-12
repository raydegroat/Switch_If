using System;

namespace Switch_If
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Enter an integer between 0 and 10 "); //Ask user
            num1 = Convert.ToInt32(Console.ReadLine()); //Get input & convert to int
            if(num1 < 0 || num1 > 10) //Evaluate user input. Check is within range
            {
                Console.WriteLine("Input out of range");
                return;
            }
            else if(num1 <= 4)
            {
                Console.WriteLine("Fail");
            }
            else if(num1 == 5)
            {
                Console.WriteLine("Pass");
            }
            else if(num1 == 6)
            {
                Console.WriteLine("Good");
            }
            else if(num1 == 7 || num1 ==8)
            {
                Console.WriteLine("Notable");
            }
            else if(num1 == 9 || num1== 10)
            {
                Console.WriteLine("Excellent"); // As Mr. Burns would say to Smithers
            }
            else  //As if anything else is even possible. But you never know.
            {
                Console.WriteLine("There's something awfully screwy going on around here");
            }
        }
    }
}
