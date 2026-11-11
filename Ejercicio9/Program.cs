using System;

namespace Ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 8, 4, 12, 3, 9, 2, 15 };
            int posicion;

            posicion = PosicionMenor(numeros);

            Console.WriteLine("El número menor es: " + numeros[posicion]);
            Console.WriteLine("Su posición es: " + posicion);
        }

        static int PosicionMenor(int[] numeros)
        {
            int menor;
            int posicion;

            menor = numeros[0];
            posicion = 0;

            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] < menor)
                {
                    menor = numeros[i];
                    posicion = i;
                }
            }

            return posicion;
        }
    }
}
