using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)

    {
        while (true)
        {
            Console.WriteLine("Wpisz haslo: ");

            string? haslo = Console.ReadLine();

            string? wynik = SprawdzHaslo(haslo);
            
            if (wynik == null)
            {
                Console.WriteLine("Haslo jest poprawne");
                break;
            }
            else
            {
                Console.WriteLine("Haslo nie spelnia wymagan.");                
                Console.WriteLine(wynik);
            }
        }
    }
    static string? SprawdzHaslo(string? haslo)
    {
        if (haslo == null)
        {
            return "Haslo nie moze byc puste";
        }

        var bledy = new List<string>();

        if (haslo.Length < 8)
        {
            bledy.Add("Haslo musi miec przynajmniej 8 znakow");
        }
        if (!haslo.Any(char.IsDigit))
        {
            bledy.Add("Haslo musi zawierac przynajmniej jedna cyfre");
        }
        if (!haslo.Any(char.IsLower))
        {
            bledy.Add("Haslo musi zawierac przynajmniej jedna mala litere");
        }
        if (!haslo.Any(char.IsUpper))
        { 
            bledy.Add("Haslo musi zawierac przynajmniej jedna duza litere");
        }
        if (haslo.Any(char.IsWhiteSpace))
        {
            bledy.Add("Haslo nie moze zawierac spacji");
        }
        if (haslo.Any(char.IsPunctuation))
        {
            bledy.Add("Haslo nie moze zawierac znakow interpunkcyjnych");
        }
        if (haslo.Any(char.IsSymbol))
        {
            bledy.Add("Haslo nie moze zawierac znakow specjalnych");
        }
        if (haslo.Contains(' '))
        {
            bledy.Add("Haslo nie moze zawierac spacji");
        }

        return bledy.Count == 0 ? null : string.Join(Environment.NewLine, bledy);
    }

}
