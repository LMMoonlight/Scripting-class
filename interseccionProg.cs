using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interseccion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 12, 18, 12, 6, 3, 6, 9, 0, 6, 12, 18 };
            int[] B = { 0, 4, 6, 10, 2, 12, 2, 18, 16, 6, 14, 8, 0, 6, 12, 18 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int Tem = 0;

           List<int> interseccion = new List<int>();
           for (int i= 0; i < A.Length; i++) // hallar iguales y anadirlos
            {
                for (int j = 0; j < B.Length; j++)
                {
                    if (A[i] == B[j])
                    {
                        interseccion.Add(A[i]);
                    }
                }
            }

            for (int i = 0; i < interseccion.Count; i++) // Ordenar los datos
            {
                for (int j = 0; j < interseccion.Count - i - 1; j++)
                {
                    if (interseccion[j] > interseccion[j + 1])
                    {
                        Tem = interseccion[j];
                        interseccion[j] = interseccion[j + 1];
                        interseccion[j + 1] = Tem;
                    }
                }
            }

            for (int i = 0; i < interseccion.Count - 1; i++) //Eliminar repetidos
            {
                if (interseccion[i] == interseccion[i + 1])
                {
                    interseccion.RemoveAt(i);
                    i = 0;
                }
            }

            for (int i = 0; i < interseccion.Count; i++)
            {
                Console.Write(interseccion[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
