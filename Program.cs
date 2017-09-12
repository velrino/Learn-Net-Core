using System;

namespace hwapp
{
    class Program
    {
        static void Main()
        {
            int guessedNumber = int.Parse(Console.ReadLine());
            switch (guessedNumber)
            {
                case 0:
                    Console.WriteLine("Sorry, 0 is not a valid guess.");
                    break;
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("You guessed low.");
                    break;
                case 4:
                    Console.WriteLine("You guessed the right number!");
                    break;
                default:
                    Console.WriteLine("You guessed high.");
                    break;
            }
        }
    }
}
