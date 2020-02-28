using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datos
{
    class Program
    {
        static void Main()
        {
            // los puntos son (0,0), (2,1), (3,5), (7,6)
            double[] CoordsX = { 0, 2, 3, 7 };
            double[] CoordsY = { 0, 1, 5, 6 };
            double maximo = 0;

            bool tresPrimeros = (CoordsX[1] - CoordsX[0]) / (CoordsX[2] - CoordsX[1]) == (CoordsY[1] - CoordsY[0]) / (CoordsY[2] - CoordsY[1]);
            Console.WriteLine(tresPrimeros);
            bool tresUltimos = (CoordsX[2] - CoordsX[1]) / (CoordsX[3] - CoordsX[2]) == (CoordsY[2] - CoordsY[1]) / (CoordsY[3] - CoordsY[2]);
            Console.WriteLine(tresUltimos );
            if (tresPrimeros && tresUltimos) Console.WriteLine("Los puntos son colineales.");
            else Console.WriteLine("Los puntos no son colineales");

            double distancia1 = Math.Sqrt(Math.Pow((CoordsX[0] - CoordsX[1]), 2) + Math.Pow((CoordsY[0] - CoordsY[1]), 2));
            Console.WriteLine("la distancia1 es: " + distancia1);
            if (distancia1 > maximo)
            {
                maximo = distancia1;
            }

            double distancia2 = Math.Sqrt(Math.Pow((CoordsX[0] - CoordsX[2]), 2) + Math.Pow((CoordsY[0] - CoordsY[2]), 2));
            Console.WriteLine("la distancia2 es: " + distancia2);
            if (distancia2 > maximo)
            {
                maximo = distancia2;
            }

            double distancia3 = Math.Sqrt(Math.Pow((CoordsX[0] - CoordsX[3]), 2) + Math.Pow((CoordsY[0] - CoordsY[3]), 2));
            Console.WriteLine("la distancia3 es: " + distancia3);
            if (distancia3 > maximo)
            {
                maximo = distancia3;
            }

            double distancia4 = Math.Sqrt(Math.Pow((CoordsX[1] - CoordsX[2]), 2) + Math.Pow((CoordsY[1] - CoordsY[2]), 2));
            Console.WriteLine("la distancia4 es: " + distancia4);
            if (distancia4 > maximo)
            {

                maximo = distancia4;
            }

            double distancia5 = Math.Sqrt(Math.Pow((CoordsX[1] - CoordsX[3]), 2) + Math.Pow((CoordsY[1] - CoordsY[3]), 2));
            Console.WriteLine("la distancia5 es: " + distancia5);       
            if (distancia5 > maximo)
            {
                maximo = distancia5;
            }

            double distancia6 = Math.Sqrt(Math.Pow((CoordsX[2] - CoordsX[3]), 2) + Math.Pow((CoordsY[2] - CoordsY[3]), 2));
            Console.WriteLine("la distancia6 es: " + distancia6);       
            if (distancia6 > maximo)
            {
                maximo = distancia6;
            }
            Console.WriteLine("El maximo fue: " + maximo);
        }
    }
}
