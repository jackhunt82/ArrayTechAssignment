/* Programmer: Jack Hunt
   Date: 9/27/2020
   Project: Tech Assignment 3b.
   Comments: This C# Console Application code demonstrates the 
             use of Arrays after getting input from users.
*/
using System;

namespace ArrayTechAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Use the try catch block to validate user input.
             If the user provides bad input, the catch block 
             will handle the error and a message will be displayed.
             */
             try
            {
                // This variable will gather data from user input
                string input = Console.ReadLine();
                // This variable will be used to perform the various iterative statements and is parsed as an integer
                int value_of_input = int.Parse(input);
                // If the value of user input is between 1 and 25, manually populate an array and iterate throughout its values
                if ((value_of_input > 0) && (value_of_input <= 25))
                {
                    Console.WriteLine("");
                    Console.WriteLine("First, let's manually populate an array with integers.");
                    Console.WriteLine("Then, let's interate through the elements in the array with a Foreach Loop");
                    // Here is the manually populated array
                    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };
                    Console.WriteLine("_______________________________________________________________________________________________");
                    Console.WriteLine("");
                    Console.WriteLine("You have entered the number: " + value_of_input);
                    Console.WriteLine("The value is " + numbers[value_of_input] + " in element #" + value_of_input + " of the array.");
                    Console.WriteLine("Here are the values in each element of the array:");
                    Console.WriteLine("________________________________________________________________________________________________");
                    Console.WriteLine("");
                    // Iterate through the array with a Foreach Loop
                    foreach (int i in numbers)
                    {
                        Console.Write(i + " ");

                    } // End of Foreach Loop
                    Console.WriteLine("");
                    Console.WriteLine("______________________________________________________________________");
                    Console.WriteLine("Press any key to exit the program...");
                    // Pause the program and await the user to press a key to end the program
                    Console.ReadKey(true);
                } // End of if
            } // End of try
            // If the user does not enter an integer, display a message
            catch
            {
                Console.WriteLine("Please input integer values only next time...");
                Console.WriteLine("Press any key to exit the program and try again...");
                Console.ReadKey(true);
            } // End of catch
        } // End of main
    } // End of class
} // End of namespace
