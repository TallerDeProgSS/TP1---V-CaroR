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
            string valor1, valor2;

            Console.Write("Ingrese limite inferior: ");
            valor1 = Console.ReadLine();   //sale un valor string y no se puede poner int 
            inferior = int.Parse(valor1);    //se pasa de string a int (lo que necesitamos)

            Console.Write("Ingrese limite superior: ");
            valor2 = Console.ReadLine();   //sale un valor string y no se puede poner int 
            superior = int.Parse(valor2);    //se pasa de string a int (lo que necesitamos)

            int contador = inferior;
            if ((inferior < superior))      //verifica que el primer número ingresado (valor1) sea menor que valor2
            {

                do
                {
                    suma = (suma + contador);
                    contador ++;
                } while (contador <= superior);             //el buque finaliza al superar a "superior"

                Console.WriteLine("El resultado es: " + suma);      //se imprime el resultado obtenido de la sumatoria
                double total = (inferior + superior) / 2;  
                Console.WriteLine("Promedio: " + total);   // calcula el promedio de los numeros ingresados
                Console.WriteLine("Minimo: " + inferior);   //imprime el número minimo que se ingresó por consola
                Console.WriteLine("Maximo: " + superior);   //imprime el número máximo que se ingresó por consola.

            }
            else
            {
                Console.WriteLine("No se puede calcular");      //en caso de que valor2 sea menos que valor1 muestra este mensaje
            }


        }
    }
}
