using System;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = Factorial(numero);

            Console.WriteLine("El factorial es: " + resultado);
        }

        static int Factorial(int numero)
        {
            if (numero == 1)
            {
                return 1;
            }

            return numero * Factorial(numero - 1);
        }
    }
}
