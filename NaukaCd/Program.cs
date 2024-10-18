using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Ulamki;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Suma wg wzoru");

        double suma = 1.0;

        for (int i = 1; i <= 20; i++)
        {
            suma += 1.0 / i;
        }

        Console.WriteLine("Suma dla liczb od 0 do 20: " + suma);
    }   

}
