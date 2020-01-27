using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese su peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su altura: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso * (Math.Pow(altura, 2));

            if (IMC <= 18.49)
            {
                Console.WriteLine("Usted esta bajo de peso");
            }
            else if (18.5 <= IMC && IMC < 25.0)
            {
                Console.WriteLine("Su peso es normal");
            }
            else if (25.0 <= IMC && IMC < 30.0)
            {
                Console.WriteLine("Usted tiene sobrepeso");
            }
            else
            {
                Console.WriteLine("Usted esta obeso");
            }

        }
    }
}
