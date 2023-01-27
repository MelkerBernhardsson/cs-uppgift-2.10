using System;
using System.Diagnostics;

namespace uppgift210
{
    class program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("vilken är din favoritbok?");
            string x = Console.ReadLine();
            Console.WriteLine("din favoritbok är "+x); 
        }
    }
}