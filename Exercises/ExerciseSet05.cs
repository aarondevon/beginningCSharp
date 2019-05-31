using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    class ExerciseSet05
    {
        // 01 - Write a program to count how many numbers between 1 and a number that are divisible by 3 with no remainder.Display the count on the console.
        public static void TotalNumbersDivisibleByThree(int topNumberRange)
        {
            int total = 0;
            for (var i = 1; i <= topNumberRange; i++)
            {
                if (i % 3 == 0)
                {
                    total += 1;
                }
            }
            Console.WriteLine($"The total numbers divisble by three between 1 and {topNumberRange} is: {total}");
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

        // 03 - Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
        public static void ComputeFactorialOfInt(int number)
        {
            int factorial = number;
            for (var i = number - 1; i >= 1; i--)
            {
                factorial *= i;
            }
            Console.WriteLine($"The factorial of {number} is: {factorial}");
        }

        // 04 - Write a program that picks a random number between 1 and 10.Give the user 4 chances to guess the number.If the user guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public static void GuessTheNumber()
        {
            Console.WriteLine("Guess a number between 1 and 10");
            Console.WriteLine("You get four guesses");
            Random random = new Random();
            int randomNumber = random.Next(1,11);
            int guesses = 4;
            for (var i = guesses; i >= 1; i--)
            {
               string input = Console.ReadLine();

                if (Convert.ToInt32(input) == randomNumber)
                {
                    Console.WriteLine("You won!");
                    break;
                }
                else if (i == 1)
                {
                    Console.WriteLine("You lost!");
                }
                else
                {
                    Console.WriteLine($"You have {i - 1} guesses left");
                }
            }
        }
    }
}
