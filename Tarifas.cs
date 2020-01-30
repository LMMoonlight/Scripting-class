using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarifas
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese cuantos smmlv gana usted");
            double s = double.Parse(Console.ReadLine());

            if (0.0 > s)
            {
                Console.WriteLine("No es posible tener un salario mensual negativo, no sea mamón.");
            }
            else if (0.0 < s && s < 2.0)
            {
                Console.WriteLine("Usted tiene la tarifa A.");
            }
            else if (2.0 <= s && s < 4.0)
            {
                Console.WriteLine("Usted tiene la tarifa B.");
            }              
            else
            {
                Console.WriteLine("Usted Tiene la tarifa C.");
            }


        }
    }
}
