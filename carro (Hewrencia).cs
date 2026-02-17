using System;

public class Carro : Vehiculo
{
    private int puertas;

    public int Puertas { get { return puertas; } set { puertas = value; } }

    public Carro(string placa, string marca, string tipo, bool disponible, int puertas)
        : base(placa, marca, tipo, disponible)
    {
        this.puertas = puertas;
    }

    public override string ObtenerDatos()
    {
        return $"{Placa},{Marca},{Tipo},{Disponible},{puertas}";
    }

    public override string ToString()
    {
        return base.ToString() + $" | Puertas: {puertas}";
    }
}