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
            
            int contador = 0; 
            double valor = 0;
            double sumatoria = 0;
            
            Console.Write("Ingrese un valor: ");
            valor = Convert.ToDouble(Console.ReadLine()); 

            while (contador <= valor)   //Se utiliza un ciclo que va desde cero hasta el límite establecido.
            {                           
                sumatoria += (Math.Pow(-1, contador)) / ((2 * contador) + 1);  // Cada valor que toma la variable 'contador' es utilizado para 
                                                                               //calcular la fórmula de Lebniz. Cada resultado se suma a la variable 'sumatoria'.
                contador++;                                                   
            }

            Console.WriteLine("El valor de pi es: " + sumatoria);   //una vez que finaliza el cálculo, el resultado es mostrado por pantalla

            double porcentaje = (double)((sumatoria * 100) / Math.PI);
            Console.Write("Siendo PI el 100%, el porcentaje de la sumatoria es {0}", porcentaje);       //Utilizando PI como 100%, se calcula el porcentaje
            Console.Write("%.");                                                                        // del resultado obtenido en el ciclo.
        }
    }
}
