namespace Exercicios.Shared;

public class Pagamento : IPagamento
{
    public virtual string Descricao => "Pagamento generico";

    public virtual bool Processar(double valor)
    {
        return valor > 0;
    }
}
