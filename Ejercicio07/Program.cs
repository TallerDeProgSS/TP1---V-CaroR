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

            //Console.Write("Ingrese la primer cadena: ");
            //a = Console.ReadLine();
            a = args[0];
            cadena1 = a.ToCharArray();

            // Console.Write("Ingrese la segunda cadena: ");
            //b = Console.ReadLine();
            b = args[1];
            cadena2 = b.ToCharArray();

            if ((a.Length == b.Length))
            {
                Array.Sort(cadena1);
                Array.Sort(cadena2);

                a = string.Join("", cadena1);
                b = string.Join("", cadena2);

                iguales = a.SequenceEqual(b);

                if (iguales)
                {
                    Console.WriteLine("Anagrama");
                }
                else
                {
                    Console.WriteLine("No son anagramas");
                }
            }
            else
            {
                Console.WriteLine("No son anagramas");


            }
        }
    }
}