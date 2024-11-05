using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)
    {
        for (int a = 0; a < 10; a++)
        {
            if (a == 5)
            {
                goto Found;
            }
            Console.WriteLine("Liczba ma wartosc " + a);
        }

        Found:
        Console.WriteLine("Znaleziono liczbe 5");
    }
    
}
