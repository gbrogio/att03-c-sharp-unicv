namespace Exercicios;

public static class Ex55_SobrescreverSacar
{
    public static void Executar()
    {
        var cc = new Shared.ContaCorrente(100); Console.WriteLine(cc.Sacar(100)); Console.WriteLine(cc.Saldo);
    }
}
