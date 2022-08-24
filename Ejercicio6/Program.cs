using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 0;
            double area = 0;
            double perimetro = 0;

            Console.Write("Ingrese un numero: ");
            n = Convert.ToDouble(Console.ReadLine());

            area = (Math.Pow(n, 2) * Math.PI);
            Console.WriteLine("El área es: " + area);

            perimetro = (2 * n * Math.PI);
            Console.WriteLine("El perímetro es: "+ perimetro);


        }
    }
}
