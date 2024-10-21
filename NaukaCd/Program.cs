using Microsoft.VisualBasic;
using System;
using System.Data;

namespace wielokrotnosc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        string? input1 = Console.ReadLine();
        int.TryParse(input1, out int liczba1);
        
        Console.WriteLine("Podaj drugą liczbę:");
        string? input2 = Console.ReadLine();
        int.TryParse(input2, out int liczba2);
        
        int dodawanie = liczba1 + liczba2;
        Console.WriteLine($"Wynik dodawania: {dodawanie}");

        int odejmowanie = liczba1 - liczba2;
        Console.WriteLine($"Wynik odejmowania: {odejmowanie}");

        int mnozenie = liczba1 * liczba2;
        Console.WriteLine($"Wynik mnozenia: {mnozenie}");

        double dzielenie = (double)liczba1 / liczba2;
        Console.WriteLine($"Wynik dzielenia: {dzielenie}");

        int modulo = liczba1 % liczba2;
        Console.WriteLine($"Wynik modulo czyli reszta z dzielenie: {modulo}");
                
    }

    
}
