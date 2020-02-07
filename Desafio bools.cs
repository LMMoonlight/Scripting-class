using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_Bool
{
    class Program
    {
        static void Main()
        {          
            Console.WriteLine("ingrese los votos por a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese los votos por b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese los votos en blanco");
            int blancos = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de votos anulados");
            int anulados = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el número de habitantes");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el porcentaje de mayores de edad");
            int p = int.Parse(Console.ReadLine());

            int poblacionMayor = n * p / 100;
            int totalVotantes = a + b + blancos + anulados;         

            int diez = totalVotantes * 10 / 100;
            int treinta = poblacionMayor * 30 / 100;

            bool c = totalVotantes > poblacionMayor;
            bool d = Math.Abs(a - b) < diez;
            bool e = totalVotantes < treinta;

            if (c || (d && e))
            {
                Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            }
            else if (a > b)
            {
                Console.WriteLine("A es el ganador");
            }
            else
            {
                Console.WriteLine("B es el ganador");
            }
        }
    }
}
