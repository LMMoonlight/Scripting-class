using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_01
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese w");
            double w = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c");
            double c = double.Parse(Console.ReadLine());
             
            //1. Calculo de e restando c
            double eGrados = 180.0 - c;
            double e = eGrados * (Math.PI / 180.0);

            //2. Ley de Seno para hallar d
            double dSen = (t * Math.Sin(e)) / w;
            double d = Math.Asin(dSen);
            double dGrados = d * (180.0 / Math.PI);

            //3. Resta de angulos internos para hallar b
            double bGrados = 180.0 - dGrados - eGrados;
            double b = bGrados * (Math.PI / 180.0);

            //4. Ley de Sen para hallar el lado x
            double x = (w * Math.Sin(b)) / Math.Sin(e);

            //verificacion
            Console.WriteLine("e es: " + eGrados);
            Console.WriteLine("d es: " + dGrados);
            Console.WriteLine("b es: " + bGrados);

            //Respuesta
            Console.WriteLine(" Entonces el lado X mide: " + x);
        }
    }
}
