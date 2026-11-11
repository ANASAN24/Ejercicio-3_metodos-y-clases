using System;

namespace Ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int exponente;
            int resultadoIterativo;
            int resultadoRecursivo;

            Console.Write("Introduce la base: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce el exponente: ");
            exponente = Convert.ToInt32(Console.ReadLine());

            resultadoIterativo = PotenciaIterativa(numero, exponente);
            resultadoRecursivo = PotenciaRecursiva(numero, exponente);

            Console.WriteLine("Resultado iterativo: " + resultadoIterativo);
            Console.WriteLine("Resultado recursivo: " + resultadoRecursivo);

            Console.ReadLine();
        }

        static int PotenciaIterativa(int numero, int exponente)
        {
            int resultado = 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado = resultado * numero;
            }

            return resultado;
        }

        static int PotenciaRecursiva(int numero, int exponente)
        {
            if (exponente == 0)
            {
                return 1;
            }

            return numero * PotenciaRecursiva(numero, exponente - 1);
        }
    }
}