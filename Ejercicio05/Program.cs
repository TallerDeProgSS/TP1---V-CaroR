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
            n = Convert.ToInt32(Console.ReadLine());                     // para no tener problemas con que n es int


            do  
            {
                sumatoria = num1 + num0;
                contador += 1;                                                    //cantidad de vueltas que da
                num0 = num1;
                num1 = sumatoria;

                Console.WriteLine(num0);                                         // se muesta el primer numero
            } while (contador <= n - 1 );


        }
    }
}