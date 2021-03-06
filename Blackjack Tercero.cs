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
            int[] totales = new int[n];
            string[] nombres = new string[n];

            int jugador = 0, maximo = 0,Tem = 0, segundo = 0, minDiferencia = 200, ganador = 0;
            string Temp = " ";

            for (int k = 0; k < n; k++)
            {
                Console.WriteLine("Ingrese el nombre de los jugadores");
                nombres[k] = Console.ReadLine(); 
            }

            while (jugador < n)
            {
                int carta1 = 0, carta2 = 0, total = 0;
                string continuar = "s";

                carta1 = aleatorio.Next(1, 11);
                carta2 = aleatorio.Next(1, 11);
                total = carta1 + carta2;

                Console.WriteLine("\nComienza: " + nombres[jugador]);
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
                            continuar = Console.ReadLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Eliminado");
                    }
                }

                Console.WriteLine("Su total fue: " + total);
                totales[jugador] = total;
                if (total > maximo && total <= 21)
                {
                    maximo = total;
                    ganador = jugador + 1;
                }
                Console.WriteLine("Gracias por participar");
                jugador++;
            }

            for (int j = 0; j < n; j++)
            {
                int Diferencia = maximo - totales[j];
                if (Diferencia < minDiferencia && Diferencia != 0 && totales[j] <= 21)
                {
                    minDiferencia = Diferencia;
                    segundo = (j+1);
                }               
            }

            for (int l = 0; l < n; l++)
            {
                for (int m = 0; m < n-l-1; m++)
                {
                    if (totales[m] > totales[m + 1])
                    {
                        Tem = totales[m];
                        totales[m] = totales[m+1];
                        totales[m + 1] = Tem;

                        Temp = nombres[m];
                        nombres[m] = nombres[m + 1];
                        nombres[m + 1] = Temp;

                    }
            
                }
            }

            for (int i = 0; i < n; i++) Console.Write(nombres[i] + " = " + totales[i] + " , ");
        }
    }
}
