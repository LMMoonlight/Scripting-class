using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socorro
{
    class Program
    {
        static void Main()
        {
            // los puntos son (0,0), (2,1), (3,5), (7,6)
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };
            double maximo = 0;
            int j = 1;

            bool tresPrimeros = (CoordsX[1] - CoordsX[0]) / (CoordsX[2] - CoordsX[1]) == (CoordsY[1] - CoordsY[0]) / (CoordsY[2] - CoordsY[1]);
            Console.WriteLine(tresPrimeros);
            bool tresUltimos = (CoordsX[2] - CoordsX[1]) / (CoordsX[3] - CoordsX[2]) == (CoordsY[2] - CoordsY[1]) / (CoordsY[3] - CoordsY[2]);
            Console.WriteLine(tresUltimos);
            if (tresPrimeros && tresUltimos) Console.WriteLine("Los puntos son colineales.");
            else Console.WriteLine("Los puntos no son colineales");

            for (int i = 0; i < 6; i++)
            {
                if (i < 3)
                {
                    double distancia1 = Math.Sqrt(Math.Pow((CoordsX[0] - CoordsX[i+1]), 2) + Math.Pow((CoordsY[0] - CoordsY[i + 1]), 2));
                    Console.WriteLine("la distancia " + (i+1) + " es: " + distancia1);
                    if (distancia1 > maximo)
                    {
                        maximo = distancia1;

                    }
                }
                else if ( i < 5)
                {
                    double distancia1 = Math.Sqrt(Math.Pow((CoordsX[1] - CoordsX[j+1]), 2) + Math.Pow((CoordsY[1] - CoordsY[j+1]), 2));
                    Console.WriteLine("la distancia " + (i + 1) + " es: " + distancia1);
                    j++;
                    if (distancia1 > maximo)
                    {
                        maximo = distancia1;
                    }
                }
                else
                {
                    double distancia1 = Math.Sqrt(Math.Pow((CoordsX[2] - CoordsX[3]), 2) + Math.Pow((CoordsY[2] - CoordsY[3]), 2));
                    Console.WriteLine("la distancia " + (i + 1) + " es: " + distancia1);
                    if (distancia1 > maximo)
                    {
                        maximo = distancia1;
                        Console.WriteLine("El maximo es: " + maximo);
                    }
                }
            }
            Console.WriteLine("El maximo fue: " + maximo);
        }
    }
}
