using System;

namespace CantidadDe0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Te diré cúantos 0 hay entre 1 y 100");
            int s = 0;
            for (int i = 1; i <= 100; i++)
            {
                string cadena = i.ToString();
                char buscar = '0';
                int C = 0;
                foreach (char c in cadena)
                {
                    if (c == buscar) ++C;
                }
                s += C;
            }
            Console.WriteLine("Hay " + s + "ceros");
            Console.ReadKey();
           
        }
    }
}
