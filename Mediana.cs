using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arreglo = { 28, 11, 96, 21, 97, 6, 18, 13, 1, 19, 51 };
            int longitud = arreglo.Length;
            int Tem = 0;
            int mitad = longitud / 2;
            int mediana = 0;

            for (int i = 0; i < arreglo.Length; i++) // Ordenar los datos
            {
                for (int j = 0; j < arreglo.Length - i - 1; j++)
                {
                    if (arreglo[j] > arreglo[j + 1])
                    {
                        Tem = arreglo[j];
                        arreglo[j] = arreglo[j + 1];
                        arreglo[j + 1] = Tem;
                    }
                }
            }

            if (longitud % 2 == 0) // si es par hay que promediar valores del centro
            {
                mediana = (arreglo[mitad - 1] + arreglo[mitad]) / 2;
            }
            else //si es impar se toma elvalor del centro
            {
                mediana = arreglo[mitad];
            }

            Console.WriteLine("la mediana es: " + mediana);
        }
    }
}
