namespace Exercicios;

public static class Ex89_MetodoRecebeIPagamento
{
    public static void Executar()
    {
        bool Processar(Shared.IPagamento p, double v) => p.Processar(v); Console.WriteLine(Processar(new Shared.PagamentoPix(), 55));
    }
}
