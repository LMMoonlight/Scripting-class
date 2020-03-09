using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Complemento
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 0, 15, 12, 18, 12, 6, 3, 6, 9, 0, 6, 12, 18 };
            int[] B = { 0, 4, 6, 10, 2, 12, 2, 18, 16, 6, 14, 8, 0, 6, 12, 18 };
            int[] U = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30 };
            int Tem = 0;

            List<int> union = new List<int>();
            List<int> complemento = new List<int>();

            for (int i = 0; i < A.Length; i++) //Agregar los datos de ambos conjuntos
            {
                union.Add(A[i]);
            }
            for (int i = 0; i < B.Length; i++)
            {
                union.Add(B[i]);
            }
            for (int i = 0; i < U.Length; i++) //Agregar los datos de U a la lista de complementos
            {
                complemento.Add(U[i]);
            }

            for (int i = 0; i < union.Count; i++) // Ordenar los datos
            {
                for (int j = 0; j < union.Count - i - 1; j++)
                {
                    if (union[j] > union[j + 1])
                    {
                        Tem = union[j];
                        union[j] = union[j + 1];
                        union[j + 1] = Tem;
                    }
                }
            }

            for (int i = 0; i < union.Count - 1; i++) //Eliminar repetidos
            {
                if (union[i] == union[i + 1])
                {
                    union.RemoveAt(i);
                    i = 0;
                }
            }
    
            for (int i = 0; i < complemento.Count; i++) // si un elemento de complemento esta en la union entonces este se elimina.
            {
                for (int j = 0; j < union.Count; j++)
                {
                    if (complemento[i] == union[j])
                    {
                        complemento.RemoveAt(i);
                    }
                }
            }

            for (int i = 0; i < complemento.Count; i++)
            {
                Console.Write(complemento[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
