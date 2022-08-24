using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01dos
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

            if ((numero == 1))
            {
                Console.WriteLine("UNO");
            }
            else if ((numero == 2))
            {
                Console.WriteLine("DOS");
            }
            else if ((numero == 3))
            {
                Console.WriteLine("TRES");
            }
            else if ((numero == 4))
            {
                Console.WriteLine("CUATRO");
            }
            else if ((numero == 5))
            {
                Console.WriteLine("CINCO");
            }
            else if ((numero == 6))
            {
                Console.WriteLine("SEIS");
            }
            else if ((numero == 7))
            {
                Console.WriteLine("SIETE");
            }
            else if ((numero == 8))
            {
                Console.WriteLine("OCHO");
            }
            else if ((numero == 9))
            {
                Console.WriteLine("NUEVE");
            }
            else
            {
                Console.WriteLine("OTROS");
            }
        }
    }
}
