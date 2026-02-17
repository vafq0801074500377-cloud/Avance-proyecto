using System;

public class Vehiculo
{
    private string placa;
    private string marca;
    private string tipo;
    private bool disponible;

    public string Placa { get { return placa; } set { placa = value; } }
    public string Marca { get { return marca; } set { marca = value; } }
    public string Tipo { get { return tipo; } set { tipo = value; } }
    public bool Disponible { get { return disponible; } set { disponible = value; } }

    public Vehiculo(string placa, string marca, string tipo, bool disponible)
    {
        this.placa = placa;
        this.marca = marca;
        this.tipo = tipo;
        this.disponible = disponible;
    }

    public virtual string ObtenerDatos()
    {
        return $"{placa},{marca},{tipo},{disponible}";
    }

    public override string ToString()
    {
        return $"Placa: {placa} | Marca: {marca} | Tipo: {tipo} | Disponible: {disponible}";
    }
}

