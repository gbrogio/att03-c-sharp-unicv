namespace Exercicios.Shared;

public class FuncionarioHeranca : PessoaHeranca
{
    public double SalarioBase { get; }

    public FuncionarioHeranca(string nome, string documento, double salarioBase) : base(nome, documento)
    {
        SalarioBase = salarioBase;
    }

    public string ObterDocumentoProtegido() => Documento;

    public override string Descrever() => $"Funcionario: {Nome}, Salario: {SalarioBase:F2}";

    public virtual double CalcularBonus() => SalarioBase * 0.1;
}
