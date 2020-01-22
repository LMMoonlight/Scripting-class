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
            //Input de los hipotenusa t y angulo a
            Console.WriteLine("Ingrese t");
            double t = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese a");
            double aGrados = double.Parse(Console.ReadLine());
            //conversion grados a rad para que esta wea no explote
            double aRad = aGrados * (Math.PI / 180.0);

            //calculo valores de los catetos 
            double z = t * Math.Cos(aRad);
            double y = t * Math.Sin(aRad);

            //calculo de c
            double c = 180.0 - 90.0 - aGrados;

            Console.WriteLine("z es:" + z);
            Console.WriteLine("y es:" + y);
            Console.WriteLine("c es:" + c);

        }
    }
}
