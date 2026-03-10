namespace Exercicios;

public static class Ex08_AplicarDesconto
{
    public static void Executar()
    {
        var prod = new Shared.Produto("Monitor", 1200); prod.AplicarDesconto(10); Console.WriteLine(prod.Preco.ToString("F2"));
    }
}
