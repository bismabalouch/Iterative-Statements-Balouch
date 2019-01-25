/*
 Author: Bisma Balouch
 Date: 01/24/2019
 Comments: This C# code uses the iterative statements to determine integar values based on user input
 */
 using System;

namespace Iterative_Statements_Balouch
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for an input
            Console.WriteLine("Please enter an integar value between 1 and 100.");

            //using try-catch block to ensure there are no errors
            try
            {
                //declaring variable 
                string input = Console.ReadLine();
                //parsing the variable 
                int input_value = int.Parse(input);

                //writing conditional statements using if-else
                if ((input_value>0) &&(input_value <=100))
                {
                    //starting the loop to check
                    Console.WriteLine("For lopp is being executed");
                    Console.WriteLine("For loop iterates  " + input_value.ToString() + "  times."); 
                    //for loop begins 
                    for (int i = 0; i<input_value; i++)
                    {
                        Console.WriteLine("You have entered " + input_value.ToString() + ".");
                        Console.WriteLine("This is the current integer value in the loop: " + i.ToString());
                    }
                    Console.WriteLine("Press any key to exit the program!");
                    Console.ReadKey(true);

                }
            } //end of try
            catch
            {
                Console.WriteLine("This could be an error message");
                Console.WriteLine();
                Console.ReadKey(true); // pauses the program 
            } //end of catch
        }
    }
}
