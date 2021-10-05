using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada tema eesnime
            //programm kuvab kasutaja eesnime esimest tähte 
            //programm kuvab kasutaja eesnime viimast tähte
            Console.WriteLine("sisesta oma eesnimi:");
            string firstname = Console.ReadLine();
            Console.WriteLine(firstname[0]);
            
            int FirstNameLenght = firstname.Length;
            Console.WriteLine($"Teie nimi on {FirstNameLenght} sümbolit pikk");

            //viimase tähe indeks = FirstNameLenght - 1
            Console.WriteLine(firstname[FirstNameLenght-1]);

        }
    }
}
