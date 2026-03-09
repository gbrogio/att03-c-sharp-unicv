using System;

namespace Exercicios;

public class ProdutoEx07
{
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

    public ProdutoEx07(double preco)
    {
        Preco = preco;
    }
}

public static class Ex07_Produto
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 07 ---");
        try
        {
            var p = new ProdutoEx07(0);
        }
        catch (ArgumentException e)
        {
            Console.WriteLine($"Erro esperado: {e.Message}");
        }

        var p2 = new ProdutoEx07(10.5);
        Console.WriteLine($"Produto válido preço: {p2.Preco:C}");
    }
}
