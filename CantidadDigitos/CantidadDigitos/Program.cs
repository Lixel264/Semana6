using System;

namespace CantidadDigitos
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
                Console.WriteLine("Lo siento, el número que ingresaste no es positivo. \n" +
                    "\n" +
                    "\nIntentalo de nuevo.");

                n = int.Parse(Console.ReadLine());
            }

            int c = n.ToString().Length;

            Console.WriteLine("El número " + n + " tiene " + c + " dígitos.");
        }
        
    }
}
