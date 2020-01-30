using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPS
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
            else if (0.0 <= s && s < 2.0)
            {
                Console.WriteLine("Usted tiene la tarifa A y sus cuotas moderadas son de 3.400$");

            }
            else if (2.0 <= s && s < 5.0)
            {

                Console.WriteLine("Usted tiene la tarifa B y sus cuotas moderadas son de 13.500$");
            }
            else
            {
                Console.WriteLine("Usted Tiene la tarifa C y sus cuotas moderadas son de 35.600$");
            }
        }
    }
}
