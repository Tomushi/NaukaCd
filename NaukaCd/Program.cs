using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Potega;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Oto liczby i ich 3 potęga:");

        for (int i = 1; i <= 20; i++)
        {
            int potega = (int)Math.Pow(i, 3);
            Console.WriteLine($"{i}^3 = {potega}");
        }
    }   
}
