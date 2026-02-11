using System;
using System.Collections.Generic;
using System.Text;

using System;
using System.Collections.Generic;

namespace GestionAlquilerVehiculos
{
    public class GestorVehiculos
    {
        private List<Vehiculo> listaVehiculos = new List<Vehiculo>();

        public void AgregarVehiculo(Vehiculo vehiculo)
        {
            listaVehiculos.Add(vehiculo);
        }

        public void ListarVehiculos()
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                v.MostrarInfo();
                Console.WriteLine("-----------------");
            }
        }

        public Vehiculo BuscarVehiculo(string placa)
        {
            foreach (Vehiculo v in listaVehiculos)
            {
                if (v.Placa == placa)
                {
                    return v;
                }
            }
            return null;
        }
    }
}