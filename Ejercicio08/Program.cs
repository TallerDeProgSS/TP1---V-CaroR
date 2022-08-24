using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 0;

            Console.Write("Ingrese dimensión: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matriz = new int[n,n]; // crea una matriz n x n

           // Console.Write("  "); //espacio principal
            for (int fila = 0; fila < n; fila++ ) //filas
            {
                
                for (int columna = 0; columna <= fila ; columna++)  //columnas
                {
                    if (fila == columna || columna == 0)
                    {
                        Console.Write(" ");
                        matriz[fila, columna] = 1;
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write(" ");
                        matriz[fila, columna] = matriz[fila - 1, columna - 1] + matriz[fila - 1, columna];  //suma de numeros
                        Console.Write(" ");
                    }
                  Console.Write( matriz[fila, columna]);
                }

                Console.WriteLine(""); // cuando termine el bucle, pasa para el siguiente renglón

            }
        }
    }
}