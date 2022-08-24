using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 1852;
            double residuo;
            bool condicion;


            while (numero <= 2023)
            {
                residuo = (numero % 4);  // si el residuo da 0, es divisible por 4 entonces puede ser un año bisiesto
                condicion = (residuo == 0); // la condicion, ya que no se puede comparar un double en el if

                if (condicion)
                {
                    residuo = (numero % 100); // si es divisible por 100 puede ser o no un año bisiesto, entonces hay que seguir las pruebas
                    condicion = (residuo == 0);

                    if (condicion)
                    {
                        residuo = (numero % 400);
                        condicion = (residuo == 0);

                        if (condicion)
                        {
                            Console.WriteLine(numero);
                        }

                    }
                    else  // el año no es divisible por 100, entonces tiene 366 días, es bisiesto
                    {
                        Console.WriteLine(numero);
                    }

                }
                numero++;  // numero + 1
            }
        }
    }
}
