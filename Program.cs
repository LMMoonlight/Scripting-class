using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa2
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, contador = 0, conDoce = 0;
            string continuar = "";

            Console.WriteLine("¿Desea lanzar los dados (s/n)?");
            continuar = Console.ReadLine();

            while (continuar == "s" && total < 100)
            {
                dado1 = aleatorio.Next(1, 13);
                total += dado1;
                contador++;
                if (dado1 != 12) conDoce = 0; else conDoce++;

                Console.WriteLine("El dado ha caido en: " + dado1);
                Console.WriteLine("Su total es: " + total);
                Console.WriteLine("contador es: " + contador);

                if (conDoce > 1 && dado1 == 10)
                {
                    Console.WriteLine("ha ganado.");
                    continuar = "n";
                }
                else if (contador > 3 && (dado1 % 2) != 0)
                {
                    Console.WriteLine("Ha salido un impar,pierdes");
                    continuar = "n";
                }
                else if (total > 100)
                {
                    Console.WriteLine("Fin del juego.");
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("¿Desea lanzar los dados (s/n)?");
                    continuar = Console.ReadLine();
                }
            }

            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por jugar.");
        }
    }
}
