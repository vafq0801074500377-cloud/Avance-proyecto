using System;

class Program
{
    static void Main(string[] args)
    {
        SistemaAlquiler sistema = new SistemaAlquiler();
        int opcion;

        do
        {
            Console.WriteLine("\n--- SISTEMA DE ALQUILER ---");
            Console.WriteLine("1. Agregar Carro");
            Console.WriteLine("2. Listar Vehículos");
            Console.WriteLine("3. Buscar Vehículo");
            Console.WriteLine("0. Salir");
            Console.Write("Opción: ");

            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Placa: ");
                    string placa = Console.ReadLine();

                    Console.Write("Marca: ");
                    string marca = Console.ReadLine();

                    Console.Write("Tipo: ");
                    string tipo = Console.ReadLine();

                    Console.Write("Número de puertas: ");
                    int puertas = int.Parse(Console.ReadLine());

                    Carro nuevo = new Carro(placa, marca, tipo, true, puertas);
                    sistema.AgregarVehiculo(nuevo);

                    Console.WriteLine("Carro agregado correctamente.");
                    break;

                case 2:
                    sistema.ListarVehiculos();
                    break;

                case 3:
                    Console.Write("Ingrese placa a buscar: ");
                    string buscar = Console.ReadLine();
                    sistema.BuscarVehiculo(buscar);
                    break;
            }

        } while (opcion != 0);
    }
}