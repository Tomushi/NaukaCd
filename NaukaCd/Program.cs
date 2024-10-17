using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Piramida;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe calkowita");

        int n = int.Parse(Console.ReadLine());

        int number = 1;

        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write(number);
                number++;
            }

            Console.WriteLine();
        }
    }
}
