using System;

namespace Operatory;

    class Program
    {
    static void Main(string[] args)
        {
        Console.WriteLine("Czesc Operatorzy");
        
        Console.WriteLine("Podaj liczbe wieksza od 14 i mniejsza od 16");
        
        string liczba = Console.ReadLine();
        
        int a = int.Parse(liczba);

        Console.WriteLine("Teraz wykonam skomplikowane obliczenia do ustalenia parzystosci kwantowej");
        
        if (a >= 14 && a <= 16)
            {
                Console.WriteLine(a + " to liczba nieparzysta");
            }

        }
    }