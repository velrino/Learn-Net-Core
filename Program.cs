using System;
using hwapp.Learn.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using hwapp.Learn.Models;

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

            Console.WriteLine(string.Format("====== YOUR CHOICE {0} ======", choose));

            if (choose == 1)
                Extension();
            else if(choose == 2)
                Lambda();
            else if(choose == 3)
                Reflection();
            else if(choose == 0)
                Environment.Exit(0);
            Start();
        }
        static string DisplayMenu()
        {
            Console.WriteLine("====== MENU ======");
            Console.WriteLine("1 - Extension");
            Console.WriteLine("2 - Lambda");
            Console.WriteLine("3 - Reflection");
            Console.WriteLine("0 - Exit");
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

        static bool Reflection()
        {
            var user = new User() { name = "Velrino", years = 21 }.Logers();
            var car = new Car() { brand = "Chrevrolet", model = "Astra" }.Logers();
            return true;
        }
    }
}
