namespace EjerciciosNet02.Ejercicio01Veterinaria;
using System.Linq;

public class AdministrarClientes
{
    public void AgregarAnimal(Registro registro, Animal animal) => registro.RegistroAnimales.Add(animal);

    public void DarBajaAnimal(Registro registro, Animal animal) => registro.RegistroAnimales.Remove(animal);

    public Animal EncontrarPaciente(Registro registro, string nombre)
    {
        for (int i=0; i< registro.RegistroAnimales.Count; i++)
        {
            if (registro.RegistroAnimales[i].Nombre == nombre)
            {
                return registro.RegistroAnimales[i];
            }
        }
        return null;
    }

    public List<Animal> ListarOrdenados(Registro registro)
    {
        return registro.RegistroAnimales
                       .OrderBy(a => a.Nombre)
                       .ToList();
    }
}