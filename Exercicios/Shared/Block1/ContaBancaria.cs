namespace Exercicios.Shared;

public class ContaBancaria
{
    private double _saldo;
    public double Saldo => _saldo;

    public void Depositar(double valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("Deposito invalido.");
        }

        _saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= 0 || valor > _saldo)
        {
            return false;
        }

        _saldo -= valor;
        return true;
    }
}
