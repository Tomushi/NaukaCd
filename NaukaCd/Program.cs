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

        string zdanie = Console.ReadLine() ?? "";

        Console.WriteLine("Ilosc slow w zdaniu to: " + CountWords(zdanie));

        Console.WriteLine();

        Console.WriteLine("Nacisnij dowolny klawisz aby zakonczyc");

        Console.ReadKey();
    }

    static int CountWords(string zdanie)
    {
        string[] slowa = zdanie.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        return slowa.Length;
    }
}
