namespace Exercicios.Shared;

public class PagamentoPix : Pagamento
{
    public override string Descricao => "Pagamento via PIX";

    public override bool Processar(double valor)
    {
        return valor > 0;
    }
}
