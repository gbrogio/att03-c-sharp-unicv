namespace Exercicios;

public static class Ex09_ContaBancariaSaldoPrivado
{
    public static void Executar()
    {
        var c = new Shared.ContaBancaria(); c.Depositar(500); Console.WriteLine(c.Saldo.ToString("F2"));
    }
}
