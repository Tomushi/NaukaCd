using System;
using System.Data;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Dni tygodnia");

        Console.WriteLine("Podaj cyfre. Zobacze jaki to dzien");

        int numerDnia = int.Parse(Console.ReadLine());

        string dzienTygodnia = (numerDnia) switch
        {
            1 => "Poniedzialek",
            2 => "Wtorek",
            3 => "Sroda",
            4 => "Czwartek",
            5 => "Piatek",
            6 => "Sobota",
            7 => "Niedziela",
            _ => "Nie ma takiego dnia",
        };

        Console.WriteLine(dzienTygodnia);
    }
}
