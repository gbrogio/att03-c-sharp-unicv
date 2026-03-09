using System;

namespace Exercicios;

// Complementa a definição parcial da classe Pessoa (existe em Ex45_CrieClassePessoa.cs)
public partial class Pessoa
{
    // Adiciona a propriedade Idade e um construtor que inicializa Nome e Idade
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

public static class Ex01_ClassePessoa
{
    public static void Executar()
    {
        var p = new Pessoa("Carlos", 30);
        Console.WriteLine("--- Exercício 01 ---");
        Console.WriteLine($"Pessoa criada: {p.Nome}, {p.Idade} anos");
    }
}
