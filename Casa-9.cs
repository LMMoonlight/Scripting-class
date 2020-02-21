using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casa9
{
    class Program
    {
        static void Main()
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, vidas = 3, seis = 0, dado2 = 0, contador = 0;
            string continuar = "";

            Console.WriteLine("¿Desea continuar (s/n)? ");
            continuar = Console.ReadLine();

            while (continuar == "s" && total < 100)

            {
                contador++;
                bool isTriple = contador % 3 == 0;
                bool isCuadruple = contador % 4 == 0;


                if (isCuadruple)
                {
                    dado1 = aleatorio.Next(1, 7);
                    dado2 = aleatorio.Next(1, 7);
                    total += dado1 + dado2;
                    Console.WriteLine("Los dados han caido en: " + dado1 + " y " + dado2);
                    if (dado1 == dado2) 
                    {
                        vidas++;
                        Console.WriteLine("Ganas una vida, tienes: " + vidas + " vidas.");
                    }
                }
                else
                {
                    dado1 = aleatorio.Next(1, 7);
                    total += dado1;
                    Console.WriteLine("El dado ha caido en: " + dado1);
                }          

                if (isTriple)
                {
                    vidas--;
                    Console.WriteLine("Pierde una vida, le quedan " + vidas + " vidas.");
                }
   
                Console.WriteLine("Su total es: " + total);

                if (vidas == 0)
                {
                    Console.WriteLine("Usted ha perdido");
                    continuar = "n";
                }
                else if (total > 100)
                {
                    Console.WriteLine("Usted ha ganado");
                    continuar = "n";
                }
                else
                {
                    Console.WriteLine("¿Desea continuar (s/n)?");
                    continuar = Console.ReadLine();
                }
            }
        }
    }
}
