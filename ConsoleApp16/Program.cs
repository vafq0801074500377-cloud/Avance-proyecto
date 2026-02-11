using System;

namespace GestionAlquilerVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorVehiculos gestor = new GestorVehiculos();

            Vehiculo v1 = new Vehiculo("M123", "Toyota", 50);
            Vehiculo v2 = new Vehiculo("M456", "Nissan", 60);

            gestor.AgregarVehiculo(v1);
            gestor.AgregarVehiculo(v2);

            Console.WriteLine("LISTA DE VEHICULOS");
            gestor.ListarVehiculos();

            Console.WriteLine("Buscar vehículo M123:");
            Vehiculo encontrado = gestor.BuscarVehiculo("M123");

            if (encontrado != null)
            {
                encontrado.MostrarInfo();
            }
            else
            {
                Console.WriteLine("Vehículo no encontrado");
            }

            Console.ReadKey();
        }
    }
}