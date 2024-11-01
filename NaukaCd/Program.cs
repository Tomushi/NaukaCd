using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)

    {
        Console.WriteLine("Podaj trzy liczby calkowite.");

        Console.WriteLine("Podaj pierwsza liczbe: ");

        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj druga liczbe: ");

        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj trzecia liczbe: ");

        int c = int.Parse(Console.ReadLine());

        if (a > 10 && b > 10 && c> 10)
        { 
            Console.WriteLine(" Wszystkie liczby sa wieksze od 10. Odpowiedz: TAK");
        }
        else
        {
            Console.WriteLine("Wszystkie liczby sa wieksze od 10. Odpowiedz: NIE");
        }
        if (a < 5 &&  b < 5 && c < 5)
        {
            Console.WriteLine("Jest liczba wieksza od 5.Odpowiedz: TAK");
        }
        else
        {
            Console.WriteLine("Jest liczba mniejsze od 5. Odpowiedz: NIE");
        }
        int licznikWiekszychOd20 = 0;

        if (a > 20) licznikWiekszychOd20++;
        if (b > 20) licznikWiekszychOd20++;
        if (c > 20) licznikWiekszychOd20++;
        if (licznikWiekszychOd20 == 1)

        {
            Console.WriteLine("Tylko jedna liczba jest wieksza od 20. Odpowiedz: TAK");
        }
        else
        {
            Console.WriteLine("Tylko jedna liczba jest wieksza od 20. Odpowiedz: NIE");
        }

    }
}
