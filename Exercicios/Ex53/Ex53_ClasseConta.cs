namespace Exercicios;

public static class Ex53_ClasseConta
{
    public static void Executar()
    {
        var c = new Shared.Conta(500); c.Sacar(100); Console.WriteLine(c.Saldo);
    }
}
