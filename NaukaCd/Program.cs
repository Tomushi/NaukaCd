using System;
using System.Data;

namespace Operatory;
class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Narodowy pomiar temperatury");
        
        Console.WriteLine("Podaj czlowieku ile masz stopni za oknem? ");
        
        int temp = int.Parse(Console.ReadLine());

        if (temp < 0)
        {
            Console.WriteLine("Cholernie pizdzi");
        }
        else if (temp >= 0 && temp < 10)
        {
            Console.WriteLine("zimno");
        }
        else if (temp >= 10 && temp < 20)
        {
            Console.WriteLine("chlodno");
        }
        else if (temp >= 20 && temp < 30)
        {
            Console.WriteLine("w sam raz");
        }
        else if (temp >= 30 && temp < 40)
        {
            Console.WriteLine("zaczyna byc nie ciekawie, bo goraco");
        }
        else if (temp >= 40 && temp < 50)
        {
            Console.WriteLine("pakuje sie na Alaske");
        }
        else if (temp >= 50)
        {
            Console.WriteLine("jestes w piekle");
        }

        {
            Console.WriteLine("Spadam ...");
        }
    }
}
