using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Podaj swoj wiek, sprawdze czy mozesz glosowac");

        Console.WriteLine("Ile masz lat");
               
        int.TryParse(Console.ReadLine(), out int wiek);
        
        Console.WriteLine("Czy jestes obywatelem Polski? (tak/nie)");               

        string odpowiedz = Console.ReadLine()?.ToLower();

        bool jestObywatelem = odpowiedz == "tak";

        if (wiek >= 18 && jestObywatelem)
        {
            Console.WriteLine("Mozesz glosowac");
        }
        else if (wiek < 18 || !jestObywatelem)
        {
            Console.WriteLine("Nie mozesz glosowac");
        }
        else
        {
            Console.WriteLine("Niepoprawne dane");
        }
    }
}
