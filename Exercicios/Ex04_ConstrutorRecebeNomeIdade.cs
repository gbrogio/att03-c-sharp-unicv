using System;

namespace Exercicios;

public class PessoaEx04
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public PessoaEx04(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public static class Ex04_Pessoa
{
    public static void Executar()
    {
        var p = new PessoaEx04("João", 25);
        Console.WriteLine("--- Exercício 04 ---");
        Console.WriteLine($"Pessoa: {p.Nome}, {p.Idade} anos");
    }
}
