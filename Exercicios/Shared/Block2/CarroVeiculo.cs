namespace Exercicios.Shared;

public class CarroVeiculo : Veiculo
{
    public CarroVeiculo(string marca) : base(marca)
    {
    }

    public override double CalcularConsumo(double distanciaKm, double litros)
    {
        return base.CalcularConsumo(distanciaKm, litros) * 1.05;
    }

    public virtual string Tipo() => "Carro";
}
