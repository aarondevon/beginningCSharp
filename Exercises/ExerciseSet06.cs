using System;
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
    }
}
