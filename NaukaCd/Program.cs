using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Diament;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Rysujemy diament");
        Console.WriteLine("Podaj wysokość diamentu: ");
        string? input = Console.ReadLine();
        if (input == null || !int.TryParse(input, out int wysokosc) || wysokosc <= 0 || wysokosc % 2 == 0)
        {
            Console.WriteLine("Popelniles blad, musisz podac liczbe dodatnia nieparzysta.");
            return;
        }

        int srodek = wysokosc / 2;
        for (int i = 0; i < wysokosc; i++)
        {
            int spacje = Math.Abs(srodek - i);
            int gwiazdki = wysokosc - 2 * spacje;

            Console.Write(new string(' ', spacje));
            Console.WriteLine(new string('*', gwiazdki));
        }
    }
}
