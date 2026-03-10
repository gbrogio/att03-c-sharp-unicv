using Exercicios.Shared;

namespace Exercicios;

public class CarroEsportivo : CarroVeiculo
{
    public CarroEsportivo(string marca) : base(marca)
    {
    }

    public sealed override string Tipo() => "Carro Esportivo";
}
