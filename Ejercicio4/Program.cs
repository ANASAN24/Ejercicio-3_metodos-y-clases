using System;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool resultado;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = EsPrimo(numero);

            if (resultado == true)
            {
                Console.WriteLine("El número es primo.");
            }
            else
            {
                Console.WriteLine("El número no es primo.");
            }

            Console.ReadLine();
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1)
            {
                return false;
            }

            for (int i = 2; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}