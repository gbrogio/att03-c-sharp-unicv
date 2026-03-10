namespace Exercicios.Shared;

public class ContaPoupanca : Conta
{
    public ContaPoupanca(double saldo) : base(saldo)
    {
    }

    public override bool Sacar(double valor)
    {
        return base.Sacar(valor);
    }
}
