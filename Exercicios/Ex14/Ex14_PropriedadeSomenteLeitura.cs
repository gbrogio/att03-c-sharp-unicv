namespace Exercicios;

public static class Ex14_PropriedadeSomenteLeitura
{
    public static void Executar()
    {
        var c = new Shared.ContaBancaria(); c.Depositar(50); Console.WriteLine(c.Saldo);
    }
}
