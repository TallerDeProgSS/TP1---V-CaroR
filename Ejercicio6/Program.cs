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
            double radio = 0;
            double area = 0;
            double perimetro = 0;

            Console.Write("Ingrese un numero: ");
            radio = Convert.ToDouble(Console.ReadLine());

            area = (Math.Pow(radio, 2) * Math.PI);          //se calcula el área la cual es la multiplicación del radio al cuadrado por PI
            Console.WriteLine("El área es: " + area);    //muestra en pantalla el resultado          

            perimetro = (2 * radio * Math.PI);                      // calcula el perímetro de un circulo que está dada por 2*  radio * PI
            Console.WriteLine("El perímetro es: "+ perimetro);  //muestra en pantalla el resultado 


        }
    }
}
