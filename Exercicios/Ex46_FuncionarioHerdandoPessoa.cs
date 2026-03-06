namespace Exercicios;

public partial class Funcionario : Pessoa
{
    public double Salario { get; set; }
}

public class Ex46_FuncionarioHerdandoPessoa
{
    public static void Executar() => Console.WriteLine("Classe Funcionario herdando de Pessoa criada.");
}