namespace Exercicios.Shared;

public class Conta
{
    public double Saldo { get; protected set; }

    public Conta(double saldo)
    {
        Saldo = saldo;
    }

    public virtual bool Sacar(double valor)
    {
        if (valor <= 0 || valor > Saldo)
        {
            return false;
        }

        Saldo -= valor;
        return true;
    }
}
