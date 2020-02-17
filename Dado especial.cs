using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, vidas = 3, seis = 0, dadoEspecial = 0, cantidadEspecial=2, uno = 0;
            string continuar = "", continuarEspecial = "";

            Console.WriteLine("¿Desea continuar (s/n)? ");
            continuar = Console.ReadLine();
            Console.WriteLine("¿Desea lanzar un dado especial(s/n)? ");
            continuarEspecial = Console.ReadLine();

            while (continuar == "s" && total < 100)
            {
                if (continuarEspecial == "s" && cantidadEspecial > 0)
                {
                    cantidadEspecial--;
                    dado1 = aleatorio.Next(1, 13);
                    total += dado1;
                    Console.WriteLine("Le quedan " + cantidadEspecial + " dados especiales.");
                }               
                else
                {
                    dado1 = aleatorio.Next(1, 7);
                    total += dado1;
                }                
               
                if (dado1 != 6) seis = 0; else seis++;
                if (dado1 == 1) uno++;

                Console.WriteLine("El dado ha caido en: " + dado1);
                Console.WriteLine("Su total es: " + total);

                if (uno == 2)
                {
                    uno = 0;
                    vidas--;
                    total = total - 10;
                    Console.WriteLine("Pierde una vida, le quedan " + vidas + " vidas.");
                    Console.WriteLine("Su nuevo total es: " + total);
                }

                if (seis > 1 && dado1 == 6 && vidas < 3)
                {
                    seis = 0;
                    vidas++;
                    Console.WriteLine("Gana una vida, ahora tiene " + vidas + " vidas.");
                }

                if (vidas == 0)
                {
                    Console.WriteLine("Usted ha perdido");
                    continuar = "n";
                }
                else if(total > 100)
                {
                    Console.WriteLine("Usted ha ganado");
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("¿Desea continuar (s/n)?");
                    continuar = Console.ReadLine();
                    if(cantidadEspecial > 0)
                    {
                        Console.WriteLine("¿Desea lanzar un dado especial(s/n)? ");
                        continuarEspecial = Console.ReadLine();
                    }
                    else
                    {
                        continuarEspecial = "n";
                    }
                    
                }
                
            }

            Console.WriteLine("Su total fue: " + total);
            Console.WriteLine("Gracias por jugar.");
        }
    }
}
