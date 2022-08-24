using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01uno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;  
            string valor;

            Console.WriteLine("Ingrese un valor: ");
            valor = Console.ReadLine();   //sale un valor string y no se puede poner int (creo)
            numero = int.Parse(valor);    //se pasa de string a int (lo que necesitamos)

            switch(numero)   //evaluamos el int
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.WriteLine("OCHO");
                    break;
                case 9:
                    Console.WriteLine("NUEVE");
                    break;
                default:                                        //indica que hacer en cualquier otro caso 
                    Console.WriteLine("OTROS");
                    break;
            }
            Console.ReadKey();
        }
    }
}
