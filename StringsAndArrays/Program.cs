using System;

namespace StringsAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada eesnime
            //programm kuvab kasutaja eesnime pikkust

            Console.WriteLine("Sisesta eesnimi:");
            string firstName = Console.ReadLine();

            //int firstNameLength = firstName.Length; //sõna pikkus
            Console.WriteLine($"Sinu eesnimes on {firstName.Length} sümbolit.");

            Console.WriteLine("Kena päeva!");
        }
    }
}
