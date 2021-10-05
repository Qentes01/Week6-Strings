using System;

namespace CompareStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab kasutajal sisestada eesnime ja perekonnanime
            //programm võrdleb sisestatud andmeid omavahel
            //programm kuvab konsoolis, kumb pikem - eesnimi või perekonnanimi

            Console.WriteLine("Sisesta eesnimi");
            string FirstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanime");
            string lastname = Console.ReadLine();

            if (lastname.Length <FirstName.Length)
            {
                Console.WriteLine("Eesnimi on pikem kui perekonnanimi.");
            }

            else if (FirstName.Length > lastname.Length)
            {
                Console.WriteLine("Perekonnanimi on pikem kui eesnimi.");
            }
            else
            {
                Console.WriteLine("Sinu eesnimi ja perekonnanimi on sama pikkad");
            }
        }
    }
}
