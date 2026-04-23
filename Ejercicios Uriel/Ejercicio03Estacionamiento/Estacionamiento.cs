namespace EjerciciosNet02.Ejercicio03Estacionamiento;

public class Estacionamiento
{
    public List<Autos> ListaAutos { get; set; } = new List<Autos>();
    public int CapacidadMaxima { get; set; }

    public Estacionamiento(int capacidadMaxima)
    {
        CapacidadMaxima = capacidadMaxima;
    }

    public bool IngresarAuto(Autos auto)
    {
        int autosEnEstacionamiento = ListaAutos.Count;
        if (autosEnEstacionamiento >= CapacidadMaxima)
        {
            return false;
        }

        ListaAutos.Add(auto);
        return true;
    }

    public bool RetirarAuto(string patente)
    {
        var auto = ListaAutos.FirstOrDefault(a => a.Patente == patente);
        if (auto != null)
        {
            ListaAutos.Remove(auto);
            return true;
        }
        return false;
    }

    public bool AutoEstacionado(string patente)
    {
        var auto = ListaAutos.FirstOrDefault(a => a.Patente == patente);
        if (auto != null)
        {
            Console.WriteLine($"El auto con patente {patente} está estacionado");
            return true;
        }
        return false;
    }

    public bool LugaresDisponibles()
    {
        int autosEnEstacionamiento = ListaAutos.Count;
        int lugaresDisponibles = CapacidadMaxima - autosEnEstacionamiento;
        Console.WriteLine($"Lugares disponibles: {lugaresDisponibles}");
        return lugaresDisponibles > 0;
    }
}