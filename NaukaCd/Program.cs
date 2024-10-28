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

        Console.WriteLine("Podaj numer miesiaca: ");
        int numerMiesiaca = int.Parse(Console.ReadLine());

        string nazwaMiesiaca = "";

        switch (numerMiesiaca)
        {
            case 1:
                nazwaMiesiaca = "Styczen";
                break;

            case 2:
                nazwaMiesiaca = "Luty";
                break;

            case 3:
                nazwaMiesiaca = "Marzec";
                break;

            case 4:
                nazwaMiesiaca = "Kwiecien";
                break;

            case 5:
                nazwaMiesiaca = "Maj";
                break;

            case 6:
                nazwaMiesiaca = "Czerwiec";
                break;

            case 7:
                nazwaMiesiaca = "Lipiec";
                break;

            case 8:
                nazwaMiesiaca = "Sierpien";
                break;

            case 9:
                nazwaMiesiaca = "Wrzesien";
                break;

            case 10:
                nazwaMiesiaca = "Pazdziernik";
                break;

            case 11:
                nazwaMiesiaca = "Listopad";
                break;

            case 12:
                nazwaMiesiaca = "Grudzien";
                break;

            default:
                nazwaMiesiaca = "Nie ma takkiego miesiaca";
                break;

        }

        Console.WriteLine("Podany miesiac to: " + nazwaMiesiaca);
    
    }
}
