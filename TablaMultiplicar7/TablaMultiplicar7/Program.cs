using System;

namespace TablaMultiplicar7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 7;
            int c = 0;
            int r = 0;

            Console.WriteLine("Esta es la tabla del 7.");

            while (c <= 12 )
            {
                r = n * c;
                Console.WriteLine(c + " x " + n + " = " + r); c++;

            }
            Console.ReadKey();
        }
    }
}
