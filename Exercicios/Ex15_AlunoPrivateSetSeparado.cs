using System;

namespace Exercicios;

public class AlunoEx15Sep
{
    public string Nome { get; private set; }

    public AlunoEx15Sep(string nome)
    {
        Nome = nome;
    }

    public void AtualizarNome(string novo)
    {
        Nome = novo;
    }
}

public static class Ex15_Aluno
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 15 ---");
        var a = new AlunoEx15Sep("Lucas");
        Console.WriteLine($"Nome inicial: {a.Nome}");
        a.AtualizarNome("Lucas Santos");
        Console.WriteLine($"Nome atualizado: {a.Nome}");
    }
}
