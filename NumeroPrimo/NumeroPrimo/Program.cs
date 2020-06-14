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

            while (n < 0)
            {
                Console.WriteLine("Lo siento, digitaste un número negativo");
                Console.WriteLine();
                Console.WriteLine("Vuelve a intentarlo");

                n = int.Parse(Console.ReadLine());

            }
            

            if (n / 1 == n && n / n == 1)
            {
                Console.WriteLine("El número que digitaste es un número primo");
            }
            else
            {
                Console.WriteLine("El número que digitaste no es un número primo");
            }
            Console.ReadKey();
        }
    }
}
