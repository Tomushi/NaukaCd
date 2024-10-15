using System;

namespace Operatory;

    class Program
    {
    static void Main(string[] args)
        {
            Console.WriteLine("Czesc Operatorzy");

            int a = 5;

            int b = 5;

            if (a == b)
            {
                Console.WriteLine(a + " i " + b + " sa rowne");
            }
            else
            {
                Console.WriteLine(a + " i " + b + " nie sa rowne");
            }
        }
    }