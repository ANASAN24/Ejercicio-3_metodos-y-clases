using System;

namespace Ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string usuario;
            string contraseña;
            bool resultado;
            int intentos = 0;

            resultado = false;

            while (intentos < 3 && resultado == false)
            {
                Console.Write("Introduce el usuario: ");
                usuario = Console.ReadLine();

                Console.Write("Introduce la contraseña: ");
                contraseña = Console.ReadLine();

                resultado = ComprobarLogin(usuario, contraseña);

                if (resultado == true)
                {
                    Console.WriteLine("Login correcto.");
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrectos.");
                }

                intentos = intentos + 1;
            }

            if (resultado == false)
            {
                Console.WriteLine("Has agotado los tres intentos.");
            }
        }

        static bool ComprobarLogin(string usuario, string contraseña)
        {
            if (usuario == "usuario2DAM" && contraseña == "pass2DAM")
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
