using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj wyraz a ja sprawdze czy jest to palindrom");

        string? wyraz = Console.ReadLine();

        wyraz = wyraz?.Replace(" ", "").ToLower()??"";
        
        char[] charArray = wyraz.ToCharArray();

        Array.Reverse(charArray);

        string odwroconyWyraz = new string(charArray);

        if (wyraz == odwroconyWyraz)
        {
            Console.WriteLine("Masz Palindroma");
        }
        else
        {
            Console.WriteLine("To nie jest Palindrom");
        }
    }
}
