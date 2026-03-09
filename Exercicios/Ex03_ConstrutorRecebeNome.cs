using System;

namespace Exercicios;

public class PessoaEx03
{
    public string Nome { get; set; }

    public PessoaEx03(string nome)
    {
        Nome = nome;
    }
}

public static class Ex03_Pessoa
{
    public static void Executar()
    {
        var p = new PessoaEx03("Mariana");
        Console.WriteLine("--- Exercício 03 ---");
        Console.WriteLine($"Nome recebido pelo construtor: {p.Nome}");
    }
}
