namespace Exercicios.Shared;

public class PagamentoCartao : Pagamento
{
    public override string Descricao => "Pagamento via Cartao";

    public override bool Processar(double valor)
    {
        return valor > 1;
    }
}
