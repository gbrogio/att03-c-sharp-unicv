using System;

namespace Exercicios;

// Adiciona o método Apresentar na classe parcial Pessoa
public partial class Pessoa
{
    public void Apresentar()
    {
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade} anos.");
    }
}

public static class Ex02_PessoaApresentar
{
    public static void Executar()
    {
        var p = new Pessoa("Mariana", 22);
        Console.WriteLine("--- Exercício 02 ---");
        p.Apresentar();
    }
}
