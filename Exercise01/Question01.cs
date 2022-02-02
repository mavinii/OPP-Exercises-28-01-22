using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 22931 - Marcos Oliveira
namespace Exercises.Exercise01
{
    public class Question01
    {
        // Constructor
        public Question01()
        {

        }

        public void Calculator()
        {
            Console.WriteLine("** Simple Calculator **");
            Console.WriteLine("");

            Console.Write("First value: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Second value: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("");

            double add, sub, times, divQuotient, divRemainder;

            add = num1 + num2;
            Console.Write($"Sum: {add}.");
            Console.WriteLine("");

            sub = num1 - num2;
            Console.Write($"Sub: {sub}.");
            Console.WriteLine("");

            times = num1 * num2;
            Console.Write($"Times: {times}.");
            Console.WriteLine("");

            divQuotient = num1 / num2;
            Console.Write($"Quotient: {divQuotient}.");
            Console.WriteLine("");

            divRemainder = num1 % num2;
            Console.Write($"Remainder: {divRemainder}.");
        }
    }
}
