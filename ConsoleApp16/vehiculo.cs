using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace GestionAlquilerVehiculos
{
    public class Vehiculo
    {
        private string placa;
        private string marca;
        private double precioPorDia;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public double PrecioPorDia
        {
            get { return precioPorDia; }
            set { precioPorDia = value; }
        }

        public Vehiculo(string placa, string marca, double precioPorDia)
        {
            this.placa = placa;
            this.marca = marca;
            this.precioPorDia = precioPorDia;
        }

        public void MostrarInfo()
        {
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Precio por día: " + precioPorDia);
        }
    }
}