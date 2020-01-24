                                                                                                                                                                                                                                                                                                                                                                                                                                      using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("escriba b0");
            double b0 = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba b1");
            double b1 = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba b2");
            double b2 = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba b3");
            double b3 = double.Parse(Console.ReadLine());
            Console.WriteLine("escriba b4");
            double b4 = double.Parse(Console.ReadLine());

            double num = (b0 * Math.Pow(2, 0)) + (b1 * Math.Pow(2, 1)) + (b2 * Math.Pow(2, 2)) + (b3 * Math.Pow(2, 3)) + (b4 * Math.Pow(2, 4));

            Console.WriteLine("El número ingresado es:" + num);
        }
    }
}
