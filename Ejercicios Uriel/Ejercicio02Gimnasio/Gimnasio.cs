namespace EjerciciosNet02.Ejercicio02Gimnasio;

public class Gimnasio
{
    public List<Socios> ListaSocios { get; set; } = new List<Socios>();
    public int CapacidadMaxima { get; set; }

    public Gimnasio(int capacidadMaxima)
    {
        CapacidadMaxima = capacidadMaxima;
    }

    public bool DarAlta(Socios socio)
    {

        int sociosActivos = ListaSocios.Count(s => s.Activo);
        if (sociosActivos >= CapacidadMaxima)
        {
            return false;
        }

        ListaSocios.Add(socio);
        return true;
    }

    public bool DarBaja(int num_socio)
    {
        var socio = ListaSocios.FirstOrDefault(s => s.Num_socio == num_socio);
        if (socio != null)
        {
            ListaSocios.Remove(socio);
            return true;
        }
        return false;
    }

    public bool MarcarCuotaPaga(int num_socio)
    {
        var socio = ListaSocios.FirstOrDefault(s => s.Num_socio == num_socio);
        if (socio != null)
        {
            socio.Activo = true;
            return true;
        }
        return false;
    }

    public bool MarcarCuotaVencida(int num_socio)
    {
        var socio = ListaSocios.FirstOrDefault(s => s.Num_socio == num_socio);
        if (socio != null)
        {
            socio.Activo = false;
            return true;
        }
        return false;
    }

    public int ObtenerCantidadSociosAlDia()
    {
        return ListaSocios.Count(s => s.Activo);
    }
}