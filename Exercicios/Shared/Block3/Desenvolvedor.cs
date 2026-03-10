namespace Exercicios.Shared;

public class Desenvolvedor : FuncionarioAbstrato
{
    public double ValorHora { get; }
    public int Horas { get; }
    public override string CargoNome => "Desenvolvedor";

    public Desenvolvedor(string nome, double valorHora, int horas) : base(nome)
    {
        ValorHora = valorHora;
        Horas = horas;
    }

    public override double CalcularSalario() => ValorHora * Horas;
}
