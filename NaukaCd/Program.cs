using Microsoft.VisualBasic;
using System;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Obliczamy pole i obwod prostokata");
        Console.WriteLine("Podaj pierwszy bok:");
        
        string? input1 = Console.ReadLine();
        int.TryParse(input1, out int bok1);
        
        Console.WriteLine("Podaj drugi bok:");
        
        string? input2 = Console.ReadLine();
        int.TryParse(input2, out int bok2);

        if(bok1 > 0 && bok2 > 0)
            {
            int pole = bok1 * bok2;
            Console.WriteLine($"Pole prostokata: {pole}");

            int obw = (bok1 + bok2) * 2;

            Console.WriteLine($"Obwod prostokada wynosi: " + obw);

            }

        else
            {
            Console.WriteLine("Liczba powinna byc dodatnia");
            }
                             
    }

    
}
