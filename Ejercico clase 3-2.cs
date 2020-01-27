using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_clase_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c");
            double c = double.Parse(Console.ReadLine());

            double d = Math.Pow(b, 2) - (4.0 * a * c);

            if (d == 0.0)
            {
                double d1 = -b / (2 * a);
                Console.WriteLine("La solución existe y es única");
                Console.WriteLine("La solucion es: " + d1);
            }
            else if (d > 0)
            {
                double d2 = (-b + Math.Sqrt(d)) / (2.0*a);
                double d3 = (-b - Math.Sqrt(d)) / (2.0 * a);
                Console.WriteLine("Existen dos soluciones correctas");
                Console.WriteLine("La solución 1 es: " + d2 + "y la solucion 2 es: " + d3);

            }
            else
            {
                Console.WriteLine("No es posible calcular.");
            }
        }
    }
}
