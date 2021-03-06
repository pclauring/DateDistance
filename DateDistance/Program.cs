﻿using System;

namespace DateDistance
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime firstDate, secondDate;
            //try catch to handle user entering an incorrectly formatted DateTime
            try
            {
                //Entry of the two dates from the user - can also accept time input from user
                Console.WriteLine("Enter first date in format MM/dd/yyyy 00:00:00");
                firstDate = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Enter second date in format MM/dd/yyyy 00:00:00");
                secondDate = Convert.ToDateTime(Console.ReadLine());

                //Visual confirmation of correct dates entered
                Console.WriteLine("The first entered time is: {0}", firstDate);
                Console.WriteLine("The second entered time is: {0}", secondDate);

                //calculates the time in days minutes hours between dates
                TimeSpan diff = secondDate - firstDate;
                Console.WriteLine("The difference between the two dates is {0} days, {1} hours, and {2} minutes.", diff.Days, diff.Hours, diff.Minutes);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Invalid entry");
            }

        }
    }
}
