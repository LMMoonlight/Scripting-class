using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            //Input de los lados Y y Z
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());

            //Calculo de la hipotenusa t
            double t = Math.Sqrt((y * y) + (z * z));

            //Calculo del angulo c y conversion a grados.
            double cRad = Math.Asin(z / t);
            double cGrados = cRad * (180.0 / Math.PI);

            //Calculo del angulo a y conversion a grados.
            double aRad = Math.Acos(z / t);
            double aGrados = aRad * (180.0 / Math.PI);

            Console.WriteLine("t es:" + t);
            Console.WriteLine("c es:" + cGrados);
            Console.WriteLine("a es:" + aGrados);
        }
    }
}
