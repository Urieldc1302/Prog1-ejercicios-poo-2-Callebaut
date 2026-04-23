namespace EjerciciosNet02.Ejercicio04TiendaMusica;

public class TiendaMusica
{
    public List<Instrumentos> ListaInstrumentos { get; set; } = new List<Instrumentos>();

    public void AgregarInstrumento(Instrumentos instrumento) => ListaInstrumentos.Add(instrumento);

    public void EliminarInstrumento(Instrumentos instrumento) => ListaInstrumentos.Remove(instrumento);

    public void IntrumentoPorCategoria(string categoria)
    {
        var instrumentosPorCategoria = ListaInstrumentos.Where(i => i.Categoria == categoria).ToList();
        if (instrumentosPorCategoria.Count > 0)
        {
            Console.WriteLine($"Instrumentos de la categoría {categoria}:");
            foreach (var instrumento in instrumentosPorCategoria)
            {
                Console.WriteLine($"- {instrumento.Nombre} - Precio: ${instrumento.Precio}");
            }
        }
        else
        {
            Console.WriteLine($"No se encontraron instrumentos de la categoría {categoria}");
        }
    }

    public void PrecioTotalIntrumentos()
    {
        int precioTotal = ListaInstrumentos.Sum(i => i.Precio);
        Console.WriteLine($"Precio total de los instrumentos en stock: ${precioTotal}");
    }
}