namespace Exercicios;

public static class Ex41_MetodoVirtualCalcularConsumo
{
    public static void Executar()
    {
        Shared.Veiculo v = new Shared.Veiculo("Ford"); Console.WriteLine(v.CalcularConsumo(200, 20));
    }
}
