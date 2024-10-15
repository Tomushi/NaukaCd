using System;

namespace Operatory;   
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj swoja date urodzenia:");
        string input = Console.ReadLine();
        int rokUrodzenia;
        
        if (!int.TryParse(input, out rokUrodzenia));

        int currentYear = DateTime.Now.Year;
        int wiek = currentYear - rokUrodzenia;

        if (wiek >= 18)

        {
            Console.WriteLine("Osoba pełnoletnia moze sie ubiegac o fotel prezydenta.");
        }
        else
        {
            Console.WriteLine("Osoba jest niepelnoletnia.");
        }
    }
}
