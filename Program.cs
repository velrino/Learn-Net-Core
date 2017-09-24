using System;
using hwapp.Learn.Extensions;
using System.Collections.Generic;
using System.Linq;

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
            if (choose == 2)
                Lambda();
            Start();
        }
        static string DisplayMenu()
        {
            Console.WriteLine("1 - Extension");
            Console.WriteLine("2 - Lambda");
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
        static bool Lambda()
        {
            int x;
            Console.WriteLine("Now write number beetwen 1 and 8");
            String Option = Console.ReadLine();
            while (!Int32.TryParse(Option, out x))
            {
                Console.WriteLine("Not a valid number, try again.");
                Lambda();
            }
            int n = int.Parse(Option);
            if (!Enumerable.Range(1, 8).Contains(n))
            {
                Console.WriteLine("Please, number beetween 1 and 8, try again.");
                Lambda();
            }
            new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 }.ListFilter(n).ForEach(i => Console.WriteLine(i));
            return true;
        }
    }
}
