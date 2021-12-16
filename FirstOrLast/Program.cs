using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees ja perekonnanimi
            //programm kontrollib andmete pikkust eraldi
            //programm kuvab kumb nendest on pikkem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi: ");
            string firstName = Console.ReadLine();

            int firstNameLength = firstName.Length;

            Console.WriteLine("Sisesta oma perekonnanimi: ");
            string lastName = Console.ReadLine();

            int lastNameLength = lastName.Length;

            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Sinu eesnimi on pikkem, kui perekonnanimi.");
            }
            else if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Sinu perekonnanimi on pikkem, kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Sinu ees- ja perekonnanimi pikkus on võrdne.");
            }
        }
    }
}
