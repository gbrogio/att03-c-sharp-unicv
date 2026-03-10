namespace Exercicios;

public static class Ex64_ClasseCirculo
{
    public static void Executar()
    {
        var c = new Shared.Circulo(3); Console.WriteLine(c.CalcularArea().ToString("F2"));
    }
}
