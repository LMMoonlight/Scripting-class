using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba su salario");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Escriba 1 si tiene contrato dependiente o 2 si es independiente.");
            int contrato = int.Parse(Console.ReadLine());
            double smmlv = 877803, arl = 0, eps = 0, pension = 0, prima = 0;
            double BC = 0.4 * salario;
            if (BC < smmlv)
            {
                BC = smmlv;
            }

            switch (contrato)
            {
                case 1:
                    eps = 0.04 * BC;
                    pension = 0.04 * BC;
                    prima = salario;
                    break;
                case 2:
                    eps = 0.125 * BC;
                    pension = 0.16 * BC;
                    Console.WriteLine("Escriba del 1 al 5 el nivel de riesgo de su empleo.");
                    int riesgo = int.Parse(Console.ReadLine());
                    switch (riesgo)
                    {
                        case 1:
                            arl = 0.522 / 100;
                            break;
                        case 2:
                            arl = 01.044 / 100;
                            break;
                        case 3:
                            arl = 2.436 / 100;
                            break;
                        case 4:
                            arl = 4.350 / 100;
                            break;
                        case 5:
                            arl = 6.960 / 100;
                            break;
                        default:
                            Console.WriteLine("Es imposible calcular su salario.");
                            break;
                    }
                    break;
                    default:
                    Console.WriteLine("Ese no es un contrato valido.");
                    break;
            }
            double salarioReal = salario - (arl * BC + pension + eps);
            double salarioAnual = salarioReal * 12 + prima;

            Console.WriteLine("Su salario real es: " + salarioReal);
            Console.WriteLine("Su salario anual es: " + salarioAnual);
        }
    }
}
