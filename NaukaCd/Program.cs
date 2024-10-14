using System;

namespace Operatory;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Czesc Operatorzy");

            Console.WriteLine("Na dzis koniec jutro ciag dalszy");

            Console.WriteLine("Dzisiejsze zajecia byly bardzo ciekawe");
        
            Console.WriteLine("Jak jest dzisiejsza data?");
            
            Console.WriteLine("Dzisiaj jest :" + DateTime.Now.ToShortDateString());
            
            Console.WriteLine("Wiec do zobaczenia jutro " + DateTime.Now + DateTime.Now.AddDays(1).ToShortDateString());
            
            Console.WriteLine("Czesc!")
        }
    }