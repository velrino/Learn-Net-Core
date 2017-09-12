﻿using System;

namespace hwapp
{
    class Program
    {
        static void Main()
        {
            string emptyString = String.Empty;
            string nullString = null;

            Console.WriteLine(emptyString); // prints nothing
            Console.WriteLine(nullString); // prints nothing

            // this line will print 0
            Console.WriteLine($"1st string is {emptyString.Length} characters long.");

            // this line will throw an exception (uncomment it to confirm)
            // Console.WriteLine($"2nd string is {nullString.Length} characters long.");
        }
    }
}
