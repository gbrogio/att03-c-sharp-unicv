namespace Exercicios;

public static class Ex10_DepositarSacar
{
    public static void Executar()
    {
        var c = new Shared.ContaBancaria(); c.Depositar(300); c.Sacar(120); Console.WriteLine(c.Saldo.ToString("F2"));
    }
}
