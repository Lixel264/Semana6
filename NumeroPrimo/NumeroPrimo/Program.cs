using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Dame un número positivo");
            n = int.Parse(Console.ReadLine());

            int c = 0;

            while (n < 0)
            {
                Console.WriteLine("Lo siento, digitaste un número negativo");
                Console.WriteLine();
                Console.WriteLine("Vuelve a intentarlo");

                n = int.Parse(Console.ReadLine());

            }

            for (int i = 1; i < (n + 1); i++)
            {
                if (n % i == 0)
                {
                    c++;
                }
            }
            if (c != 2)
            {
                Console.WriteLine("El número que digitaste no es un número primo");
            }
            else
            {
                Console.WriteLine("El número que digitaste es un número primo");
            }
            Console.ReadKey();
        }
    }
}
