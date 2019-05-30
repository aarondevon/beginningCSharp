﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class ExerciseSet06
    {
        // 01 - Write a program to count how many numbers between 1 and a number that are divisible by 3 with no remainder.Display the count on the console.
        public static int TotalNumbersDivisibleByThree(int topNumberRange)
        {
            int total = 0;
            for (var i = 1; i <= topNumberRange; i++)
            {
                if (i % 3 == 0)
                {
                    total += 1;
                }
            }
            return total;
        }

        // 02 - Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously entered numbers and display it on the console.
        public static void AskUserToEnterNumber()
        {
            int total = 0;
            do
            {
                Console.WriteLine("Enter a number, or enter 'ok' to exit.");
                string input = Console.ReadLine();
                if (input == "ok")
                {
                    break;
                }
                total += Convert.ToInt32(input);
            } while (true);
            
            Console.WriteLine($"Total: {total}");
        }
    }
}
