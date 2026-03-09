using System;

namespace Exercicios;

public class ProdutoEx06
{
    public string Nome { get; set; }

    private double preco;
    public double Preco
    {
        get => preco;
        set
        {
            if (value <= 0) throw new ArgumentException("Preço deve ser maior que zero.");
            preco = value;
        }
    }

    public ProdutoEx06(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        if (percentual < 0 || percentual > 100) throw new ArgumentException("Percentual inválido.");
        Preco -= Preco * (percentual / 100.0);
    }
}

public static class Ex06_Produto
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 06-08 ---");
        try
        {
            var p = new ProdutoEx06("Caneta", 2.5);
            Console.WriteLine($"Produto: {p.Nome}, Preço: {p.Preco:C}");
            p.AplicarDesconto(10);
            Console.WriteLine($"Após 10% desconto: {p.Preco:C}");

            // teste de preço inválido
            var p2 = new ProdutoEx06("Lápis", 0);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro esperado: {e.Message}");
        }
    }
}
