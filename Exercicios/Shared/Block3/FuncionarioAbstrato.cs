namespace Exercicios.Shared;

public abstract class FuncionarioAbstrato
{
    public string Nome { get; }
    public abstract string CargoNome { get; }

    protected FuncionarioAbstrato(string nome)
    {
        Nome = nome;
    }

    public abstract double CalcularSalario();
    public virtual string Cargo() => $"Cargo: {CargoNome}";
}
