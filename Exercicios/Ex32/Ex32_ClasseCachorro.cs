namespace Exercicios;

public static class Ex32_ClasseCachorro
{
    public static void Executar()
    {
        var c = new Shared.Cachorro { Nome = "Rex" }; Console.WriteLine(c.EmitirSom());
    }
}
