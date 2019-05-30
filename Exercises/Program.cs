using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise Set 06*************************************
            // 01 - Write to the console the total numbers between 1 and 100 that are divisible by 3 with no remainder.
            ExerciseSet06.TotalNumbersDivisibleByThree(100);

            // 02 - Ask the user to enter a number or "ok" to exit. Calculates the sum of all the previously entered numbers and displays it on the console.
            ExerciseSet06.AskUserToEnterNumber();

            // 03 - Ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

            ExerciseSet06.ComputeFactorialOfInt(5);

            // 04 - Guess the radom number
            ExerciseSet06.GuessTheNumber();
        }
    }
}
