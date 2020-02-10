using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Juego
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int carta1 = 0, carta2 = 0, total = 0;
            string continuar = "";

            carta1 = aleatorio.Next(1, 11);
            carta2 = aleatorio.Next(1, 11);
            total = carta1 + carta2;

            Console.WriteLine("Sus cartas son: " + carta1 + " y " + carta2);
            Console.WriteLine("Su total es: " + total);
            Console.WriteLine("¿Desea tomar 1 carta (s/n)?" );
            continuar = Console.ReadLine();

            while (continuar == "s" && total < 21)
            {
                carta1 = aleatorio.Next(1, 11);
                total += carta1;
                Console.WriteLine("su carta es: " + carta1); 
                Console.WriteLine("Su total es: " + total);
                if (total <= 21)
                {
                    Console.WriteLine("¿Desea tomar 1 carta (s/n)?");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Eliminado");
                }                
            }

            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por participar");
        }
    }
}
