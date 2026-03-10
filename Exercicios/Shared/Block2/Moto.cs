namespace Exercicios.Shared;

public class Moto : Veiculo
{
    public Moto(string marca) : base(marca)
    {
    }

    public override double CalcularConsumo(double distanciaKm, double litros)
    {
        return base.CalcularConsumo(distanciaKm, litros) * 1.15;
    }
}
