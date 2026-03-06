namespace Exercicios;

public class Gerente : Funcionario
{
    public string Departamento { get; set; }
}

public class Ex47_GerenteHerdandoFuncionario
{
    public static void Executar()
    {
        Gerente g = new Gerente { Nome = "Alex", Salario = 7500.00, Departamento = "Engenharia" };
        Console.WriteLine($"Gerente: {g.Nome} | Salário: {g.Salario:C} | Setor: {g.Departamento}");
    }
}