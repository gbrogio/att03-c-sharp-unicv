namespace Exercicios;

public static class Ex87_PagamentoCartao
{
    public static void Executar()
    {
        Shared.IPagamento p = new Shared.PagamentoCartao(); Console.WriteLine(p.Descricao);
    }
}
