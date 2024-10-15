using System;

namespace Operatory;

    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbę:");
        int liczba = int.Parse(Console.ReadLine());

        if (liczba < 0)
        {
            Console.WriteLine(liczba + " jest liczbą ujemna.");
        }
        else
        {
            Console.WriteLine(liczba + " jest liczbą dodatnia");
        }
    }
}