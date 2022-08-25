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

                if (condicion)          //verifica que la condición sea verdadera
                {
                    residuo = (numero % 100); // si es divisible por 100 puede ser o no un año bisiesto, entonces hay que seguir las pruebas
                    condicion = (residuo == 0);

                    if (condicion)          //verifica que la condición sea verdadera
                    {
                        residuo = (numero % 400);       //si es divisible por 400, es bisiesto.
                        condicion = (residuo == 0);     

                        if (condicion)      //verifica que la condición sea verdadera
                        {
                            Console.Write(numero + " - ");     //es bisiesto, entonces se muestra por pantalla.
                        }

                    }
                    else  // el año no es divisible por 100, entonces tiene 366 días, es bisiesto
                    {
                        Console.Write(numero + " - ");         //imprime el año bisiesto.
                    }

                }
                numero++;  
            }
        }
    }
}
