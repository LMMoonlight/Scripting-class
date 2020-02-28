using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arreglosClase
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Numero de datos");
            int n = int.Parse(Console.ReadLine());
            int[] edades = new int[n];
            string[] nombres = new string[n];
            int max = 0, min = 200, total = 0, elegido = 0;
            string mayor = " ", menor = " ";
            double diferencia = 0, minDif = 20000;

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("nombres: ");
                string nombre = Console.ReadLine();
                nombres[i] = nombre;
                Console.WriteLine("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                edades[i] = edad;
                total += edad;

                if (edad > max)
                {
                    max = edad;
                    mayor = nombre;
                }
                if (edad < min)
                {
                    min = edad;
                    menor = nombre;
                }
                
            }

            double promedio = total / n;
            double desviacion = 0, sumatoria = 0;
            for (int j = 0; j < nombres.Length; j++)
            {
                sumatoria += Math.Pow(edades[j] - promedio, 2);
                diferencia = Math.Sqrt(Math.Pow(edades[j] - promedio, 2) / n);
                desviacion = Math.Sqrt( sumatoria / n);
                if (diferencia < minDif)
                {
                    minDif = diferencia;
                    elegido = j;
                    
                }
            }
            Console.WriteLine("El elegido es: " + nombres[elegido]);
            Console.WriteLine("El mayor es: " + mayor + " y su edad es: " + max);
            Console.WriteLine("El menor es: " + menor + " y su edad es: " + min);
            Console.WriteLine("El promedio es: " + promedio + " y la desviacion " + desviacion);

        }
    }
}
