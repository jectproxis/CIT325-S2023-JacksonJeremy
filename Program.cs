using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoleApplication
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double width, height, woodLength, glassArea;
            string widthString, heightString;

            string name = "Jeremy Jackson";
            string location = "Idaho";

            DateTime today = DateTime.Today;
            DateTime christmas = new DateTime(2023, 12, 25);
            TimeSpan daysUntilChristmas = christmas.Subtract(today);

            Console.WriteLine("There are " + daysUntilChristmas.Days + " days until Christmas.");
            Console.WriteLine("My name is " + name + ".");
            Console.WriteLine("I am from " + location + ".");

            Console.WriteLine("Please provide the Width of the glass of the glass being glazed.");
            widthString = Console.ReadLine();
            width = double.Parse(widthString);

            Console.WriteLine("Please provide the length of the glass being glazed.");
            heightString = Console.ReadLine();
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            Console.WriteLine("The length of the wood is " + woodLength + " feet");
            Console.WriteLine("The area of the glass is " + glassArea + " square metres");

            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
