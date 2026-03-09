using System;

namespace Exercicios;

public class AlunoEx14Sep
{
    public string Nome { get; }

    public AlunoEx14Sep(string nome)
    {
        Nome = nome;
    }
}

public static class Ex14_Aluno
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 14 ---");
        var a = new AlunoEx14Sep("Miguel");
        Console.WriteLine($"Nome somente leitura: {a.Nome}");
    }
}
