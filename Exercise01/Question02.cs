using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Exercise01
{
    public class Question02
    {
        // Constructor
        public Question02()
        {

        }

        public void Carpeting()
        {
            // Carpeting store
            Console.WriteLine("** Carpeting Store **");
            Console.WriteLine("");

            Console.Write("What is the length of the room? ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("What is the width of the room? ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Carpet Price £5.99m².");

            // Const price
            double carpetingPrice = 5.99;
            double totalArea = length * width;
            double calculatedPrice = totalArea * carpetingPrice;
            Console.WriteLine("");
            
            Console.WriteLine("Total area in square metres: "+totalArea);
            Console.WriteLine("Calculated price: £"+calculatedPrice);
        }
    }
}
