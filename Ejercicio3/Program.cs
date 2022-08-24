using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int contador = 1; // para que empiece la sumatoria desde el 1
            double n = 0;
            double sumatoria = 0;
            
            Console.Write("Ingrese un valor: ");
            n = Convert.ToDouble(Console.ReadLine());  // para no tener problemas con que n es int

            while (contador != n + 1)   // si n=1, tiene que dar una vuelta si o si, entonces se hace n+1
            {
                sumatoria = sumatoria + (Math.Pow(-1, contador)) / ((2 * contador) + 1);  // Formula de Lebniz
                contador += 1;
            }

            Console.WriteLine("El valor de pi es: " + sumatoria);

        }
    }
}
