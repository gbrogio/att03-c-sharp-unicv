namespace Exercicios;

public static class Ex27_InitOnlyProperty
{
    public static void Executar()
    {
        var c = new ConfigInit { Chave = "abc123" }; Console.WriteLine(c.Chave);
    }
}
