using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cwiczenia");

        Console.WriteLine("Napisz nazwe miesiaca: ");

        string? miesiac = Console.ReadLine();

        int numerMiesiaca;

        switch (miesiac)
        {
            case "Styczen":
                numerMiesiaca = 1;
                break;

            case "Luty":
                numerMiesiaca = 2;
                break;

            case "Marzec":
                numerMiesiaca = 3;
                break;

            case "Kwiecien":
                numerMiesiaca = 4;
                break;

            case "Maj":
                numerMiesiaca = 5;
                break;

            case "Czerwiec":
                numerMiesiaca = 6;
                break;

            case "Lipiec":
                numerMiesiaca = 7;
                break;

            case "Sierpien":
                numerMiesiaca = 8;
                break;

            case "Wrzesien":
                numerMiesiaca = 9;
                break;

            case "Pazdziernik":
                numerMiesiaca = 10;
                break;

            case "listopad":
                numerMiesiaca = 11;
                break;

            case "Grudzien":
                numerMiesiaca = 12;
                break;

            default:
                Console.WriteLine ("Nie ma takiego miesiaca");
                return;

        }

        Console.WriteLine($"Numer miesiaca to: " + numerMiesiaca);
    
    }
}
