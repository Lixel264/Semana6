using System;

namespace CantidadDe0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Te diré cúantos 0 hay entre 0 y 100");
            int cero = 0;
            for (int i = 0; i <= 100; i+=10)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Entre 0 y 100 hay 9 ceros.");
            Console.WriteLine();
            Console.WriteLine("Pero si contamos el 0 y el 100, entonces tenemos 12 ceros");
            Console.ReadKey();
           
        }
    }
}
