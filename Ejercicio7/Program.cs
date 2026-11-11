using System;

namespace Ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1;
            int numero2;
            bool resultado1;
            bool resultado2;

            Console.Write("Introduce el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultado1 = EsMultiplo(numero1, numero2);
            resultado2 = EsMultiplo(numero2, numero1);

            if (resultado1 == true || resultado2 == true)
            {
                Console.WriteLine("Uno de los números es múltiplo del otro.");
            }
            else
            {
                Console.WriteLine("Ninguno de los números es múltiplo del otro.");
            }
        }

        static bool EsMultiplo(int numero1, int numero2)
        {
            if (numero2 != 0 && numero1 % numero2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}