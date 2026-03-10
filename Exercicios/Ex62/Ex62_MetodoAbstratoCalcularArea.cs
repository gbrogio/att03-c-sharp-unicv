namespace Exercicios;

public static class Ex62_MetodoAbstratoCalcularArea
{
    public static void Executar()
    {
        Shared.Forma f = new Shared.Circulo(2); Console.WriteLine(f.CalcularArea().ToString("F2"));
    }
}
