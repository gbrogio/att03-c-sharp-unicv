namespace Exercicios.Shared;

public class Quadrado : Forma
{
    public double Lado { get; }
    public override string Nome => "Quadrado";

    public Quadrado(double lado)
    {
        Lado = lado;
    }

    public override double CalcularArea() => Lado * Lado;
}
