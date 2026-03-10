namespace Exercicios.Shared;

public abstract class Forma
{
    public abstract string Nome { get; }
    public abstract double CalcularArea();
    public virtual string Descricao() => $"Forma: {Nome}";
}
