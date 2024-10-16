using System;
using System.Data;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Oceny");

        Console.WriteLine("Podaj cyfre. Wybierz od 1 do 6. Zamienie to na forme opisowa");
    
        int ocena = int.Parse(Console.ReadLine());

        string ocenaOpisowa = ocena switch
        {
            1 => "Niedostateczny",
            2 => "Dopuszczajacy",
            3 => "Dostateczny",
            4 => "Dobry",
            5 => "Bardzo dobry",
            6 => "Celujacy",
            _ => "Nie ma takiej oceny",
        };
        Console.WriteLine($"{ocenaOpisowa}");
    }
}
