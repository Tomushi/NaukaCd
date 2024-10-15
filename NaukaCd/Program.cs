using System;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Ile masz wzrostu?");
        int wzrost = int.Parse(Console.ReadLine());

        if (wzrost < 150)
        {
            Console.WriteLine("Jesteś krasnoludem");
        }
        else if (wzrost < 180)
        {
            Console.WriteLine("Jesteś średniego wzrostu");
        }
        else
        {
            Console.WriteLine("Jesteś wysoki");
        }
    }
}
