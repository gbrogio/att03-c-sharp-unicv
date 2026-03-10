namespace Exercicios;

public class FuncionarioEncapsulado
{
    private string _nome;
    private double _salario;

    public string Nome
    {
        get => _nome;
        set => _nome = string.IsNullOrWhiteSpace(value) ? throw new ArgumentException("Nome invalido") : value;
    }

    public double Salario
    {
        get => _salario;
        private set => _salario = value < 0 ? throw new ArgumentException("Salario invalido") : value;
    }

    public FuncionarioEncapsulado(string nome, double salario)
    {
        _nome = string.Empty;
        Nome = nome;
        Salario = salario;
    }

    public void AumentarSalario(double percentual)
    {
        if (percentual < 0)
        {
            throw new ArgumentException("Percentual invalido");
        }

        Salario += Salario * (percentual / 100.0);
    }

    public override string ToString() => $"Funcionario: {Nome}, Salario: {Salario:F2}";
}
