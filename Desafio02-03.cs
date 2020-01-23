using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main()
        {
            //Input de los hipotenusa z y angulo c
            Console.WriteLine("Ingrese z");
            double z = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese c");
            double cGrados = double.Parse(Console.ReadLine());
            //conversion grados a rad para que esta wea no explote
            double cRad = cGrados * (Math.PI / 180.0);

            //calculo valores de los lados 
            double t = z / Math.Sin(cRad);
            double y = z / Math.Tan(cRad);

            //calculo de a
            double a = 180.0 - 90.0 - cGrados;

            Console.WriteLine("t es:" + t);
            Console.WriteLine("y es:" + y);
            Console.WriteLine("a es:" + a);

        }
    }
}
