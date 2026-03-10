namespace Exercicios;

public static class Ex86_PagamentoPix
{
    public static void Executar()
    {
        Shared.IPagamento p = new Shared.PagamentoPix(); Console.WriteLine(p.Descricao);
    }
}
