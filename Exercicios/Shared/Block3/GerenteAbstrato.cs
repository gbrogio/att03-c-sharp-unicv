namespace Exercicios.Shared;

public class GerenteAbstrato : FuncionarioAbstrato
{
    public double SalarioBase { get; }
    public override string CargoNome => "Gerente";

    public GerenteAbstrato(string nome, double salarioBase) : base(nome)
    {
        SalarioBase = salarioBase;
    }

    public override double CalcularSalario() => SalarioBase + 1500;

    public override string Cargo() => base.Cargo() + " (lideranca)";
}
