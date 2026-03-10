namespace Exercicios;

public static class Ex11_ValidarSaque
{
    public static void Executar()
    {
        var c = new Shared.ContaBancaria(); c.Depositar(100); Console.WriteLine(c.Sacar(150));
    }
}
