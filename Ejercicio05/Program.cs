using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int n = 0;
            int sumatoria = 0;
            int tot = 0;
            int num0 = 0;
            int num1= 1;
            

            Console.Write("Ingrese un valor: ");
            n = Convert.ToInt32(Console.ReadLine());                     


            do  
            {
                sumatoria = num1 + num0;                            //suma los dos últimos valores que contienen las variables
                contador += 1;                                       //cantidad de vueltas que da
                num0 = num1;                                        //a num0 se le asigna el valor de la variable num1
                num1 = sumatoria;                                   // a num1 se le asigna el valor de "sumatoria"

                Console.WriteLine(num0);                             // se muesta el primer resultado que se dió
            } while (contador <= n - 1 );                           //finaliza cuando la variable "contador" supera (n - 1)


        }
    }
}