using System;

namespace Ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int resultado;

            Console.Write("Introduce un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            resultado = SumarDigitos(numero);

            Console.WriteLine("La suma de los dígitos es: " + resultado);
        }

        static int SumarDigitos(int numero)
        {
            int suma = 0;
            int digito;

            while (numero > 0)
            {
                digito = numero % 10;
                suma = suma + digito;
                numero = numero / 10;
            }

            return suma;
        }
    }
}
