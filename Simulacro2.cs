using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacro
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, dado2 = 0, total = 0, i = 0, j = 0, d =0 ; //i son los turnos y j el resultado > 6, d es el contador de dobles.
            string continuar = "";
            double porcentaje;

            Console.WriteLine("¿Desea lanzar los dados (s/n)?");
            continuar = Console.ReadLine();            

            while (continuar == "s" && total < 100 && (dado1 != 1 || dado2 != 1))
            {
                dado1 = aleatorio.Next(1, 7);
                dado2 = aleatorio.Next(1, 7);
                total += dado1 + dado2;
                i++;
                Console.WriteLine("Los dados han caido en: " + dado1 + " y " + dado2);
                Console.WriteLine("Su total es: " + total);
                Console.WriteLine("i es: " + i);                

                if ((dado1 + dado2) > 6)
                {
                    j++;
                    Console.WriteLine("j es: " + j);
                }

                if (dado1 != dado2)
                {
                    d = 0;
                }
                else if (dado1 == dado2 && dado1 != 1)
                {
                    d++;
                    Console.WriteLine("lleva " + d + " dobles.");  
                    if (d == 3)
                    {
                        Console.WriteLine("Usted ha ganado");
                        break;
                    }
                }

                if (dado1 == 1 && dado2 == 1)
                {
                    Console.WriteLine("Usted ha perdido");
                    continuar = "n";
                }
                else if(total <= 100)
                {             
                    Console.WriteLine("¿Desea lanzar los dados (s/n)?");
                    continuar = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Usted ha ganado");
                    continuar = "n";
                }
            }

            Console.WriteLine("i es: " + i);
            Console.WriteLine("j es: " + j);
            porcentaje = ((j *100.0) / (100.0 * i)) * 100.0;
            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("su porcentaje de turnos mayores a 6 es: " + porcentaje + "%");
            Console.WriteLine("Gracias por jugar.");

        }
    }
}
