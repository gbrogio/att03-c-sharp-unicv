namespace Exercicios;

public static class Ex36_PolimorfismoListaAnimal
{
    public static void Executar()
    {
        var lista = new List<Shared.Animal> { new Shared.Cachorro(), new Shared.Gato() }; foreach (var a in lista) Console.WriteLine(a.EmitirSom());
    }
}
