using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main()
        {
            int a = 3, b = 69, blancos = 19, anulados = 81, n = 1699, p = 27;
            Console.WriteLine("ingrese los votos por a");
            Console.WriteLine("ingrese los votos por b");
            Console.WriteLine("ingrese los votos en blanco");
            Console.WriteLine("ingrese la cantidad de votos anulados");
            Console.WriteLine("ingrese el número de habitantes");
            Console.WriteLine("ingrese el porcentaje de mayores de edad");

            int poblacionMayor = n * p / 100;
            int totalVotantes = a + b + blancos + anulados;
            int abstinencia = poblacionMayor - totalVotantes;
            int idk = (a + b) * 30 / 100;

            bool c = anulados < idk;
            bool d = (a + b) > blancos;
            bool e = abstinencia < totalVotantes;

            if ((c || (d && e)) && a > b)
            {
                Console.WriteLine("A es el ganador");
            }
            else if ((c || (d && e)) && a < b)
            {
                Console.WriteLine("B es el ganador");
            }
            else
            {
                Console.WriteLine("Las elecciones deben repetirse");
            }           
            
        }
    }
}
