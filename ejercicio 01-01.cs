using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_01_04
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese b");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());

            //b de grados a rad
            double b = bGrados * (Math.PI / 180.0);

            //1. Calculo de t
            double t = Math.Sqrt((y * y) + (z * z));
            //2. Calculo de angulo a y verificación
            double a = Math.Atan(y / z);
            double aGrados = a * (180.0 / Math.PI);
            //3. suma de ambos angulos
            double f = b + a;
            //4. Calculo de lado w
            double w = z / Math.Cos(f);
            //5. Ley de Coseno, Bloody hell AIBDKKJAJK
            double x2 = Math.Pow(t, 2) + Math.Pow(w, 2) - (2 * t * w * Math.Cos(b));
            double x = Math.Sqrt(x2);

             //verificaciones
            Console.WriteLine(" t es: " + t);
            Console.WriteLine("a es:" + aGrados);
            Console.WriteLine("w es:" + w);

            //Resultado
            Console.WriteLine(" Entonces el valor de x es:" + x);
            
        }
    }
}
