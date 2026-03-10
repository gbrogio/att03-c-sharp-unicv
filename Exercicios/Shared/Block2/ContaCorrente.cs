namespace Exercicios.Shared;

public class ContaCorrente : Conta
{
    public ContaCorrente(double saldo) : base(saldo)
    {
    }

    public override bool Sacar(double valor)
    {
        return base.Sacar(valor + 2.5);
    }
}
