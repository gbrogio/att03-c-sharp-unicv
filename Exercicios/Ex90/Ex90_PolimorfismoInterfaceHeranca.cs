namespace Exercicios;

public static class Ex90_PolimorfismoInterfaceHeranca
{
    public static void Executar()
    {
        var pagamentos = new List<Shared.IPagamento> { new Shared.Pagamento(), new Shared.PagamentoPix(), new Shared.PagamentoCartao() }; foreach (var p in pagamentos) Console.WriteLine($"{p.Descricao}: {p.Processar(50)}");
    }
}
