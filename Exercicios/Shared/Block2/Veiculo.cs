namespace Exercicios.Shared;

public class Veiculo
{
    public string Marca { get; }

    public Veiculo(string marca)
    {
        Marca = marca;
    }

    public virtual double CalcularConsumo(double distanciaKm, double litros)
    {
        return litros == 0 ? 0 : distanciaKm / litros;
    }
}
