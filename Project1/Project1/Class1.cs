//Shelby Williams
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {

            string firstname;
            firstname = "Shelby";

            int favoriteNumber = 13;

            double crazyNumber = 7.2343 * favoriteNumber;

            string lastName = "Williams";
            string fullName = firstname + " " + lastName;

            Console.WriteLine("Please enter your first name: >>");
            firstname = Console.ReadLine();

            Console.WriteLine("Please enter your last name: >>");
            lastName = Console.ReadLine();

            Console.WriteLine("Please enter your favorite name: >>");
            string favoriteNumberAsString = Console.ReadLine();
            favoriteNumber = Convert.ToInt32(favoriteNumberAsString);

            fullName = firstname + " " + lastName;
            crazyNumber = 7.2343 * favoriteNumber;

            Console.WriteLine(fullName + " has the favorite number of " + favoriteNumber + " \nwhich equates to a crazy number of " + crazyNumber + ".");

            // MAKE IT DYNAMIC

            Console.ReadKey();

        }
    }
}
