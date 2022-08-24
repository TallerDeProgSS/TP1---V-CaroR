namespace ejercicio08
{
    class Program08
    {
        private const string V = "";

        static void Main(string[] args)
        {
            Console.WriteLine("Ingresar orden del triangulo:");
            int orden = Convert.ToInt32(Console.ReadLine());
            string filas = "";
            int[,] M = new int[orden, orden];
            for (int i = 0; i < orden; i++)
            {
                M[i, 0] = 1;
                M[i, i] = 1;

                if (i >= 2)
                {
                    for (int column = 1; column < i; column++)
                    {
                        M[i, column] = M[i - 1, column] + M[i - 1, column - 1];
                    }
                }
            }
            string espacioBlanco = "   ";  //espacio entre cada elemento, tiene que ser el doble que espacioBlanco2.
            string espacioBlanco2 = "  ";  //espacio al principio de cada fila para poder formar el triangulo equilatero
            string espacioBlanco3 = " ";  //La suma de todos los espacioBlanco2
            int OrdenCopy = orden;

            for (int columna = 0; columna < orden; columna++)
            {
                for (int contador = OrdenCopy; contador != 1; contador = contador - 1)
                {
                    espacioBlanco3 += espacioBlanco2;
                }

                for (int fila = 0; fila < columna + 1; fila++)
                {
                    filas = filas + espacioBlanco + Convert.ToInt32(M[columna, fila]);
                }
                filas = espacioBlanco3 + filas;
                Console.WriteLine(filas);
                filas = V;
                espacioBlanco3 = " ";
                OrdenCopy--;
            }

        }
    }
}