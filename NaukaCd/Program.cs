using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Napisz zdanie a ja policze ile jest w nim danego znaku");

        string zdanie = Console.ReadLine();

        Console.WriteLine("Podaj znak ktory chcesz policzyc");

        char znak = Console.ReadKey().KeyChar;

        Console.WriteLine();
               
        Console.WriteLine("W podanym zdaniu jest " + policzZnaki(zdanie, znak) + " znakow " + znak);
    }

    static int policzZnaki(string zdanie, char znak)
    {
        int licznik = 0;

        foreach (char l in zdanie)
        {
            if (l == znak)
            { 
                licznik++;
            }
        }
        return licznik;
    }
}
