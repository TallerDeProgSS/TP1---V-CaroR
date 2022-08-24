using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            int inferior, superior, promedio;
            int suma = 0;
            int contador = 0;
            string valor1, valor2;

            Console.Write("Ingrese limite inferior: ");
            valor1 = Console.ReadLine();   //sale un valor string y no se puede poner int (creo)
            inferior = int.Parse(valor1);    //se pasa de string a int (lo que necesitamos)

            Console.Write("Ingrese limite superior: ");
            valor2 = Console.ReadLine();   //sale un valor string y no se puede poner int (creo)
            superior = int.Parse(valor2);    //se pasa de string a int (lo que necesitamos)

            if ((inferior < superior))
            {
               
                while (contador != superior)
                {
                    suma += (inferior + contador);
                    contador += 1;
                }
                Console.WriteLine("El resultado es: "+ suma);
                double total = (inferior + superior) / 2;  // double se usa para representar numero reales.
                Console.WriteLine("Promedio: " + total);
                Console.WriteLine("Minimo: " + inferior);
                Console.WriteLine("Maximo: " + superior);
                
            }
            else
            {
                Console.WriteLine("No se puede calcular");
            }


        }
    }
}
