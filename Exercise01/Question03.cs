using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 22931 - Marcos Oliveira
namespace Exercises.Exercise01
{
    public class Question03
    {
        public Question03()
        {

        }

        public void hoursAndMinutes()
        {
            // Display amount of time in hours and minutes
            Console.WriteLine("** Hours and Minutes **");
            Console.WriteLine("");

            Console.Write("Enter the time in minutes: ");
            int totalMinutes = int.Parse(Console.ReadLine());

            // C# class can be used to calculate Sec, Days, Hrs and Min
            var result = TimeSpan.FromHours(totalMinutes);

            Console.WriteLine($"Amount in hours: {result.TotalHours}h.");
            Console.WriteLine($"Amount in minutes: {result.TotalMinutes}m.");
        }
        
    }
}
