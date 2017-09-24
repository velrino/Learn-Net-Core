using System;
using hwapp.Learn.Extensions;

namespace hwapp
{
    class Program
    {
        static void Main()
        {
            Start();
        }

        static void Start()
        {
            int x;
            String option = DisplayMenu();

            while (!Int32.TryParse(option, out x))
            {
                Console.WriteLine("Not a valid number, try again.");
                option = DisplayMenu();
            }
            int choose = int.Parse(option);
            if (choose == 1)
                Extension();
            Start();
        }
        static string DisplayMenu()
        {
            Console.WriteLine("1 - Extension");
            Console.WriteLine("2 - Lorem Ipsum");
            Console.WriteLine("3 - Lorem Ipsum");
            String option = Console.ReadLine();
            return option;
        }

        static bool Extension()
        {
            Console.WriteLine("Write a number");
            int n = int.Parse( Console.ReadLine() );
            Console.WriteLine( ExtensionApply(n) );
            return true;
        }
        static bool ExtensionApply(int n)
        {
            Console.WriteLine( "Applying extension CSharp concept" );
            Console.WriteLine( string.Format("Number Duplicate : {0}", n.Dupicate() ) );
            Console.WriteLine( string.Format("Number Triplicate : {0}", n.Triplicate() ) );
            Console.WriteLine( string.Format("Number Triplicate by Duplicate : {0}", n.Triplicate().Dupicate() ) );
            return true;
        }
    }
}
