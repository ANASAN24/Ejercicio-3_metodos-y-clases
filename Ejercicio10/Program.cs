using System;

namespace Ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco banco = new Banco();

            banco.Operar();

            banco.ObtenerEstado();

            Console.ReadLine();
        }
    }

    class Cliente
    {
        private string nombre;
        private double cantidadTotal;

        public Cliente(string nombre)
        {
            this.nombre = nombre;
            cantidadTotal = 0;
        }

        public void Ingresar(double cantidad)
        {
            cantidadTotal = cantidadTotal + cantidad;
        }

        public void Sacar(double cantidad)
        {
            cantidadTotal = cantidadTotal - cantidad;
        }

        public double GetCantidadTotal()
        {
            return cantidadTotal;
        }

        public void MostrarInformacion()
        {
            Console.WriteLine("Cliente: " + nombre);
            Console.WriteLine("Dinero en la cuenta: " + cantidadTotal);
        }
    }

    class Banco
    {
        private Cliente cliente1;
        private Cliente cliente2;
        private Cliente cliente3;

        public Banco()
        {
            cliente1 = new Cliente("Ana");
            cliente2 = new Cliente("Carlos");
            cliente3 = new Cliente("Maria");
        }

        public void Operar()
        {
            cliente1.Ingresar(500);
            cliente2.Ingresar(750);
            cliente3.Ingresar(300);
        }

        public void ObtenerEstado()
        {
            double total;

            total = cliente1.GetCantidadTotal() +
                    cliente2.GetCantidadTotal() +
                    cliente3.GetCantidadTotal();

            Console.WriteLine("Dinero total ingresado en el banco: " + total);
            Console.WriteLine();

            cliente1.MostrarInformacion();
            Console.WriteLine();

            cliente2.MostrarInformacion();
            Console.WriteLine();

            cliente3.MostrarInformacion();
        }
    }
}