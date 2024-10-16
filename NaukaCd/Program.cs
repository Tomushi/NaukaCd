using System;
using System.Data;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoje wyniki z matury z poszczegolnych przedmiotow.");
        
        Console.WriteLine("Podaj wynik z Matematyki: ");
        
        int mat = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wynik z Fizyki: ");

        int fiz = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj wynik z Chemii: ");

        int chem = int.Parse(Console.ReadLine());

        if ((mat >= 70 && fiz >= 55 && chem >= 45) || mat + fiz >= 150 || mat + chem >= 150)
        {
            Console.WriteLine("Gratulacje, zostales przyjety na studia!");
        }
        else
        {
            Console.WriteLine("Niestety, nie zostales przyjety na studia.");
        }

    }
}
