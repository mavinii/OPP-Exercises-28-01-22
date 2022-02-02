using Exercises.Exercise01;
using System;

// 22931 - Marcos Oliveira
namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Question 1: Simple Calculator
            Question01 question01 = new();
            question01.Calculator();

            //// Question 2: Carpeting Store
            Question02 question02 = new();
            question02.Carpeting();

            // Question 3: Time and Minutes
            Question03 question03 = new();
            question03.hoursAndMinutes();
        }
    }
}
