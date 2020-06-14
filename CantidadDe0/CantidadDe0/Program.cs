using System;

namespace CantidadDe0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Te diré cúantos 0 hay entre 0 y 100");
            int cero = 3;
            for (int i = 1; i < 100; i++)
            {
                if (i % 10 == 0)
                {
                    cero++;
                }
            }
            Console.WriteLine("Entre 0 y 10 hay " + cero + " ceros");
           
        }
    }
}
