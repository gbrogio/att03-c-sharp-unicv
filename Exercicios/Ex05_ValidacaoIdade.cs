using System;

namespace Exercicios;

public class PessoaEx05
{
    public string Nome { get; set; }

    private int idade;
    public int Idade
    {
        get => idade;
        set
        {
            if (value < 0) throw new ArgumentException("Idade não pode ser negativa.");
            idade = value;
        }
    }

    public PessoaEx05(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public static class Ex05_Pessoa
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 05 ---");
        try
        {
            var p = new PessoaEx05("Ana", -2);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro esperado: {e.Message}");
        }

        var p2 = new PessoaEx05("Ana", 20);
        Console.WriteLine($"Pessoa válida: {p2.Nome}, {p2.Idade} anos");
    }
}
