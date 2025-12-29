using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Package_Express
{
    class Program
    {
        static void Main(string[] args)
        {
            // Display the welcome message
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Ask the user to enter the package weight
            Console.WriteLine("Please enter the package weight:");
            int weight = Convert.ToInt32(Console.ReadLine()); // Store weight as decimal

            // Check if the package is too heavy
            if (weight > 50)
            {
                // Display error message and end the program
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Stops the program immediately
            }

            // Ask the user to enter the package width
            Console.WriteLine("Please enter the package width:");
            int width = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the package height
            Console.WriteLine("Please enter the package height:");
            int height = Convert.ToInt32(Console.ReadLine());

            // Ask the user to enter the package length
            Console.WriteLine("Please enter the package length:");
            decimal length = Convert.ToDecimal(Console.ReadLine());

            // Calculate the total of the dimensions
            decimal dimensionTotal = width + height + length;

            // Check if the package is too large
            if (dimensionTotal > 50)
            {
                // Display error message and end the program
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Stops the program immediately
            }

            // Calculate the shipping quote
            // Multiply width, height, and length together
            // Then multiply by weight
            // Finally divide by 100
            decimal quote = (width * height * length * weight) / 100;

            // Display the final shipping quote formatted as currency
            Console.WriteLine($"Your estimated total for shipping this package is: $" + quote);

            // Display a thank-you message
            Console.WriteLine("Thank you!");
            Console.ReadLine();
        }
    }
}
