using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackjackValid
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            Console.WriteLine("Ingrese el numero de jugadores (Min 2 y Max 5)");
            int n = int.Parse(Console.ReadLine());
            while (n < 2 || n > 5)
            {
                Console.WriteLine("Error. Ingrese el numero de jugadores(Min 2 y Max 5)");
                n = int.Parse(Console.ReadLine());
            }

            int jugador = 0, maximo = 0, ganador = 0;

            while (jugador < n)
            {
                int carta1 = 0, carta2 = 0, total = 0;
                string continuar = "s";

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;

                Console.WriteLine("Comienza jugador: " + (jugador+1));
                Console.WriteLine("Sus cartas son: " + carta1 + " y " + carta2);
                Console.WriteLine("Su total es: " + total);
                Console.WriteLine("¿Desea tomar 1 carta (s/n)?");
                continuar = Console.ReadLine();
                while (continuar != "s" && continuar != "n")
                {
                    Console.WriteLine("Error. ¿Desea tomar 1 carta (s/n)?");
                    continuar = Console.ReadLine();
                }

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
                        while (continuar != "s" && continuar != "n")
                        {
                            Console.WriteLine("Error. ¿Desea tomar 1 carta (s/n)?");
                            continuar =Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eliminado");
                    }
                }

                Console.WriteLine("Su total fue: " + total);
                if (total > maximo)
                {
                    maximo = total;
                    ganador = jugador+1;
                }
                Console.WriteLine("Gracias por participar");
                jugador++;
            }
            Console.WriteLine("El ganador es el jugador " + ganador);
        }
    }
}
