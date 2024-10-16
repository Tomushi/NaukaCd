using System;
using System.Data;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Czy mozna stworzyc trojkat?");
        
        Console.WriteLine("Podaj trzy liczby potrzebne do jego stworzenia");

        Console.WriteLine("Podaj pierwsza liczbe");
        
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Podaj druga liczbe");
        
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Podaj trzecia liczbe");
        
        int c = Convert.ToInt32(Console.ReadLine());
        
        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("Mozna stworzyc trojkat");
        }
        else
        {
            Console.WriteLine("Nie mozna stworzyc trojkata");
        }
    }
}
