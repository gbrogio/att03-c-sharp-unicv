namespace Exercicios.Shared;

public class GerenteHeranca : FuncionarioHeranca
{
    public GerenteHeranca(string nome, string documento, double salarioBase) : base(nome, documento, salarioBase)
    {
    }

    public override double CalcularBonus()
    {
        return base.CalcularBonus() + 500;
    }

    public override string Descrever() => $"Gerente: {Nome}, Bonus: {CalcularBonus():F2}";
}
