namespace Exercicios;

public static class Ex31_ClasseAnimal
{
    public static void Executar()
    {
        var a = new Shared.Animal { Nome = "Bicho" }; Console.WriteLine(a.EmitirSom());
    }
}
