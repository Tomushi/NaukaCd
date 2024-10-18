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
        if (input1 == null || !int.TryParse(input1, out int liczba1))
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe.");
            return;
        }

        Console.WriteLine("Podaj drugą liczbę:");
        string? input2 = Console.ReadLine();
        if (input2 == null || !int.TryParse(input2, out int liczba2))
        {
            Console.WriteLine("Nieprawidłowe dane wejściowe.");
            return;
        }

        int nww = NajmniejszaWspolnaWielokrotnosc(liczba1, liczba2);
        Console.WriteLine("Najmniejsza wspólna wielokrotność: " + nww);
    }

    static int NajmniejszaWspolnaWielokrotnosc(int a, int b)
    {
        return Math.Abs(a * b) / NajwiekszyWspolnyDzielnik(a, b);
    }

    static int NajwiekszyWspolnyDzielnik(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
