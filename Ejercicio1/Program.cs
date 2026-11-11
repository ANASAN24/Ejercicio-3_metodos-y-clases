using System;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tamaño;
            int suma;
            double media;

            Console.Write("Introduce el tamaño del array: ");
            tamaño = Convert.ToInt32(Console.ReadLine());

            int[] numeros = new int[tamaño];

            suma = 0;

            for (int i = 0; i < tamaño; i++)
            {
                Console.Write("Introduce un número: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                suma = suma + numeros[i];
            }

            media = Convert.ToDouble(suma) / tamaño;

            Console.WriteLine("La suma es: " + suma);
            Console.WriteLine("La media es: " + media);
        }
    }
}
