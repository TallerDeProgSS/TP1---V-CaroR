using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            bool iguales;
            char[] cadena1;
            char[] cadena2;

            a = args[0];
            cadena1 = a.ToCharArray();


            b = args[1];
            cadena2 = b.ToCharArray();

            if ((a.Length == b.Length))     //verifica que ambos string tengan igual longitud
            {
                Array.Sort(cadena1);        //agrega a la lista
                Array.Sort(cadena2);        //agrega a la lista

                a = string.Join("", cadena1);   //concatena los elementos
                b = string.Join("", cadena2);   //concatena los elementos

                iguales = a.SequenceEqual(b);       //verifica si son iguales

                if (iguales)           //verifica que la condición sea verdadera
                {
                    Console.WriteLine("Anagrama");  //si cumple muestra en pantalla que son anagramas
                }
                else
                {
                    Console.WriteLine("No son anagramas");      //en caso de no cumplir
                }
            }
            else
            {
                Console.WriteLine("No son anagramas");  //si tiene diferente longitud muestra que no lo son


            }
        }
    }
}