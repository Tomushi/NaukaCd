using Microsoft.VisualBasic;
using System;
using System.Data;

namespace Petle;

class Program
{
    static void Main(string[] args)
    {
        int liczbyParzyste = 0;

        Console.WriteLine("Liczby parzyste z zakresu od 1 d 1000 to: ");

        do
        {
            if (liczbyParzyste % 2 == 0)
            {
                Console.WriteLine(liczbyParzyste);
            }
            liczbyParzyste++;
        } while (liczbyParzyste <= 1000);

        Console.WriteLine("Ilosc liczb parzystych wynosi: " + liczbyParzyste);
        Console.WriteLine("Dziekuje za uwage.");
    }
}
