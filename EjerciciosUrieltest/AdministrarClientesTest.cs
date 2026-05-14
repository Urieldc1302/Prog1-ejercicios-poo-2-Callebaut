namespace EjerciciosUrieltest;
using NUnit.Framework;

[TestFixture]
public class AdministrarClientesTest
{
    [Test]
    public void AgregarAnimalTest()
    {
        var administrarclientes = new Administrarclientes();

        var animal = new Animal(){Nombr="hola", Especie="perro", Edad=1};
        
        Assert.That(animal.AgregarAnimal, Is.Not.Null);
    }
}