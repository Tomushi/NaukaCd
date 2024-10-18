using Microsoft.VisualBasic;
using System;
using System.Data;

namespace binaria;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe dziesietna do zamiany na binarna:");
        string? input = Console.ReadLine();

        if (input == null || !int.TryParse(input, out int liczbaDziesietna))
        {
            Console.WriteLine("Zle dane, nie dawaj przecinkow ani kropek");
            return;
        }

        string liczbaBinarna = Convert.ToString(liczbaDziesietna, 2);
        Console.WriteLine("Liczba binarna: " + liczbaBinarna);
    }
}
