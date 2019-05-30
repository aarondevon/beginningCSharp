using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise Set 06*************************************
            // 01 Write to the console the total numbers between 1 and 100 that are divisible by 3 with no remainder.
            Console.WriteLine(ExerciseSet06.TotalNumbersDivisibleByThree(100));

            // 02 - Ask the user to enter a number or "ok" to exit. Calculates the sum of all the previously entered numbers and displays it on the console.
            ExerciseSet06.AskUserToEnterNumber();
        }
    }
}
