namespace Exercicios;

public static class Ex85_ClassePagamento
{
    public static void Executar()
    {
        Shared.IPagamento p = new Shared.Pagamento(); Console.WriteLine(p.Processar(10));
    }
}
