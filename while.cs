using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @while
{
    class Program
    {
        static void Main()
        {
            double total = 0;
            Console.WriteLine("Ingrese el número de datos (n): ");
            int n = int.Parse(Console.ReadLine());
            int i = 0, max = 0, min = 200;
            string mayor = "n", menor = "n";

            while(i < n)
            {
                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

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
                total += edad;
                i++;
            }

            double promedio = total / n;
            Console.WriteLine("Promedio =" + promedio);
            Console.WriteLine("Mayor = " + max + " y su nombre es: " + mayor);
            Console.WriteLine("Menor =" + min + " y su nombre es: " + menor);
        }
    }
}
