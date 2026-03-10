namespace Exercicios.Shared;

public class Circulo : Forma
{
    public double Raio { get; }
    public override string Nome => "Circulo";

    public Circulo(double raio)
    {
        Raio = raio;
    }

    public override double CalcularArea() => Math.PI * Raio * Raio;
}
