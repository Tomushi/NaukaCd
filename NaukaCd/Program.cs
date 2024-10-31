using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Napisz zdanie a ja policze ilosc slow w nim zawartych");

        string zdanie = Console.ReadLine();

        Console.WriteLine("Ilosc slow w zdaniu to: " + CountWords(zdanie));

        Console.WriteLine();

        Console.WriteLine("Nacisnij dowolny klawisz aby zakonczyc");
    }

    static int CountWords(string zdanie)
    {
        int iloscSlow = 0;
        int index = 0;

        while (index < zdanie.Length)
        {
            while (index < zdanie.Length && Char.IsWhiteSpace(zdanie[index]) == true)
                index++;

            if (index < zdanie.Length)
                iloscSlow++;

            while (index < zdanie.Length && Char.IsWhiteSpace(zdanie[index]) == false)
                index++;
        }

        return iloscSlow;
    }
}
