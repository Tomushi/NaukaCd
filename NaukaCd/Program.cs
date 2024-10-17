using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Petle;

class Program
{
    static void Main(string[] args)
    {
        int liczbaPierwszych = 0;

        for (int liczba = 2; liczba <= 150; liczba++)
        {
            bool czyPierwsza = true;

            for (int i = 2; i <= Math.Sqrt(liczba); i++)
            {
                if (liczba % i == 0)
                {
                    czyPierwsza = false;
                    break;
                }
            }

            if (czyPierwsza)
            {
                liczbaPierwszych++;
                Console.WriteLine(liczba + " jest liczbą pierwszą.");
            }
        }

        Console.WriteLine("Liczba liczb pierwszych w zakresie 0 - 100: " + liczbaPierwszych);
    }
}
