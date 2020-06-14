using System;

namespace RNG
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();

            int n = rng.Next(50, 100);

            Console.WriteLine("El número generado es " + n);
            Console.WriteLine();
            Console.WriteLine("Si desea hacer otro número generado presione S");

            string t;
            t = Console.ReadLine();

            while (t == "s" || t == "S")
            {
                n = rng.Next(50, 101);

                Console.WriteLine("El número generado es " + n);
                Console.WriteLine();
                Console.WriteLine("Si desea hacer otro número generado presione S");
                t = Console.ReadLine();
            }
            Console.ReadKey();

        }
    }
}
