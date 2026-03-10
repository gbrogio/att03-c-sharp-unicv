namespace Exercicios;

public static class Ex88_ListaIPagamento
{
    public static void Executar()
    {
        var lista = new List<Shared.IPagamento> { new Shared.PagamentoPix(), new Shared.PagamentoCartao() }; foreach (var p in lista) Console.WriteLine(p.Descricao);
    }
}
