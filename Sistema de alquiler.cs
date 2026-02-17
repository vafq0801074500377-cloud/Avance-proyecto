using System;
using System.Collections.Generic;
using System.IO;

public class SistemaAlquiler
{
    private List<Vehiculo> vehiculos = new List<Vehiculo>();
    private string archivo = "vehiculos.txt";

    public SistemaAlquiler()
    {
        CargarDesdeArchivo();
    }

    public void AgregarVehiculo(Vehiculo v)
    {
        vehiculos.Add(v);
        GuardarEnArchivo();
    }

    public void ListarVehiculos()
    {
        foreach (var v in vehiculos)
        {
            Console.WriteLine(v);
        }
    }

    public void BuscarVehiculo(string placa)
    {
        foreach (var v in vehiculos)
        {
            if (v.Placa == placa)
            {
                Console.WriteLine("Vehículo encontrado:");
                Console.WriteLine(v);
                return;
            }
        }
        Console.WriteLine("No encontrado.");
    }

    private void GuardarEnArchivo()
    {
        using (StreamWriter sw = new StreamWriter(archivo))
        {
            foreach (var v in vehiculos)
            {
                sw.WriteLine(v.ObtenerDatos());
            }
        }
    }

    private void CargarDesdeArchivo()
    {
        if (File.Exists(archivo))
        {
            string[] lineas = File.ReadAllLines(archivo);

            foreach (var linea in lineas)
            {
                string[] datos = linea.Split(',');

                if (datos.Length == 5)
                {
                    Carro carro = new Carro(
                        datos[0],
                        datos[1],
                        datos[2],
                        bool.Parse(datos[3]),
                        int.Parse(datos[4])
                    );
                    vehiculos.Add(carro);
                }
                else if (datos.Length == 4)
                {
                    Vehiculo v = new Vehiculo(
                        datos[0],
                        datos[1],
                        datos[2],
                        bool.Parse(datos[3])
                    );
                    vehiculos.Add(v);
                }
            }
        }
    }
}