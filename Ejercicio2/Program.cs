using System;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase;
            int resultado;

            Console.Write("Introduce una frase: ");
            frase = Console.ReadLine();

            resultado = ContarEspacios(frase);

            Console.WriteLine("Número de espacios: " + resultado);
        }

        static int ContarEspacios(string texto)
        {
            int contador = 0;

            for (int i = 0; i < texto.Length; i++)
            {
                if (texto[i] == ' ')
                {
                    contador = contador + 1;
                }
            }

            return contador;
        }
    }
}
