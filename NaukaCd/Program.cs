using Microsoft.VisualBasic;
using System;
using System.ComponentModel.Design;
using System.Data;

namespace cwiczenia;
class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Proste liczenia");
            Console.WriteLine("Podaj pierwsza liczbe: ");

            string? input1 = Console.ReadLine();
            int.TryParse(input1, out int liczba1);

            Console.WriteLine("Podaj druga liczbe: ");

            string? input2 = Console.ReadLine();
            int.TryParse(input2, out int liczba2);

        while (true)
        {
            Console.WriteLine("Wybierz dzialanie: ");

            Console.WriteLine("1. Dodawanie");

            Console.WriteLine("2. Odejmowanie");

            Console.WriteLine("3. Mnozenie");

            Console.WriteLine("4. Dzielenie");           

            Console.WriteLine("5. Wyjscie");

            string? dzialanie = Console.ReadLine();
                        
            if (dzialanie == "1")
            {
                int wynik = liczba1 + liczba2;
                Console.WriteLine($"Wynik dzialania to: {wynik}");
            }
            else if (dzialanie == "2")
            {
                int wynik = liczba1 - liczba2;
                Console.WriteLine($"Wynik dzialania to: {wynik}");
            }
            else if (dzialanie == "3")
            {
                int wynik = liczba1 * liczba2;
                Console.WriteLine($"Wynik dzialania to: {wynik}");
            }
            else if (dzialanie == "4")
            {

                if (liczba2 != 0)
                {
                    double wynik = (double) liczba1 / liczba2;
                    Console.WriteLine($"Wynik dzialania to: {wynik}");
                }
                else
                {
                    Console.WriteLine("Nie mozna dzielic przez 0");
                    continue;
                }
            }
            else if (dzialanie == "5")
            {
                Console.WriteLine("Koniec programu");
                break;

            }
            else
            {
                Console.WriteLine("Niepoprawne dzialanie");
                continue;
            }
                                            
        }
        
    }

    
}
