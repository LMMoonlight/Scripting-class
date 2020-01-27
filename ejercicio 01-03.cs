using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_01_02
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese w");
            double w = double.Parse(Console.ReadLine());   
            Console.WriteLine("Ingrese x");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese d");
            double dGrados = double.Parse(Console.ReadLine());
            // d de grados a rad
            double d = dGrados * (Math.PI / 180.0);

            //calculo de y despejando de Cos(d) = (x + y) / w
            double y = (w * Math.Cos(d)) - x;

            //Resultado
            Console.WriteLine("y es: " + y);
        }
    }
}
