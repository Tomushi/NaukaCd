using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Kalkulator");

        Console.WriteLine("Podaj pierwsza liczbe :");

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj druga liczbe :");

        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Teraz wybierz numer operacji.");

        Console.WriteLine("1. Dodawanie");

        Console.WriteLine("2. Odejmowanie");

        Console.WriteLine("3. Mnozenie");

        Console.WriteLine("4. Dzielenie");

        int operacja = int.Parse(Console.ReadLine());

        switch (operacja)
        {
            case 1:
                Console.WriteLine("Wynik to : " + (a + b));
                break;
            case 2:
                Console.WriteLine("Wynik to : " + (a - b));
                break;
            case 3:
                Console.WriteLine("Wynik to : " + (a * b));
                break;
            case 4:
                Console.WriteLine("Wynik to : " + (a / b));
                break;
            default:
                Console.WriteLine("Nie ma takiej operacji");
                break;
        }
        
        Console.WriteLine("Dzieki za wspolne liczenie :)");

    }
}
