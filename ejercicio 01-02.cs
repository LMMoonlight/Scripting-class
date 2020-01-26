using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio_01_03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese b");
            double bGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese d");
            double dGrados = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese y");
            double y = double.Parse(Console.ReadLine());

            //Calculo de e con suma de angulos internos
            double eGrados = 180.0 - bGrados - dGrados;
            //calculo de c restando
            double cGrados = 180.0 - eGrados;

            //conversion de cgrados a rad
            double c = cGrados * (Math.PI / 180.0);
            //calculo con Tan
            double z = Math.Tan(c) * y;

            //Verificacion
            Console.WriteLine("e vale:" + eGrados);
            Console.WriteLine("c vale:" + cGrados);

            //Resultado
            Console.WriteLine(" Entonces z vale:" + z);
        }
    }
}
