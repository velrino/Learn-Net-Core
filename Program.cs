using System;

namespace hwapp
{
    class Program
    {
        static void Main()
        {
            string one = "abc";
            string two = "123";
            string combined = one + two; // "abc123"

            Console.WriteLine(combined);

            string original = "Test string";
            string capital = original.ToUpper(); // TEST STRING
            string lower = original.ToLower(); // test string
            string lower2 = "Another Test".ToLower(); // another test

            Console.WriteLine(original);
            Console.WriteLine(capital);
            Console.WriteLine(lower);
            Console.WriteLine(lower2);
        
            string input = " Steve "; // has a space at the start and end.
            string clean1 = input.TrimStart(); // "Steve "
            string clean2 = input.TrimEnd(); // " Steve"
            string clean3 = input.Trim(); // "Steve"
            string shortversion = input.Trim().Substring(0,3); // "Ste"

            Console.WriteLine($"*{input}*");
            Console.WriteLine($"*{clean1}*");
            Console.WriteLine($"*{clean2}*");
            Console.WriteLine($"*{clean3}*");
            Console.WriteLine($"*{shortversion}*");
        
        }
    }
}
