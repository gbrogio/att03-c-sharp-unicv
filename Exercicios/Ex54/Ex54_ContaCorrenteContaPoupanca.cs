namespace Exercicios;

public static class Ex54_ContaCorrenteContaPoupanca
{
    public static void Executar()
    {
        var cc = new Shared.ContaCorrente(500); var cp = new Shared.ContaPoupanca(500); cc.Sacar(100); cp.Sacar(100); Console.WriteLine($"CC:{cc.Saldo} CP:{cp.Saldo}");
    }
}
