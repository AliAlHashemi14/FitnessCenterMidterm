using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessCenterMidterm
{
    internal class Validator
    {


        //public static void GetClub()
        //{
        //    while (true)
        //    {
        //        int choice = int.Parse(Console.ReadLine());
        //        if (clubs.Contains(choice))
        //        {
        //            Console.WriteLine($"You've chosen {clubs});
        //        }
        //        else if ()

        //    }



        //}
        public static void GetInput()
        {
            while (true)
            {

                Console.WriteLine("Would you like to join a club? (y/n)");
                string choice = Console.ReadLine().ToLower().Trim();

                if (choice == "y")
                {
                    Console.WriteLine("Which club would you like to join?");
                    break;
                }
                else if (choice == "n")
                {
                    Console.WriteLine("Have a great day!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect input.");
                }
            }

        }
    }
}
