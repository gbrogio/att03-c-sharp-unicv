using System;

namespace Exercicios;

public class ProdutoEx08
{
    public double Preco { get; private set; }

    public ProdutoEx08(double preco)
    {
        if (preco <= 0) throw new ArgumentException("Preço deve ser maior que zero.");
        Preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        if (percentual < 0 || percentual > 100) throw new ArgumentException("Percentual inválido.");
        Preco -= Preco * (percentual / 100.0);
    }
}

public static class Ex08_Produto
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 08 ---");
        var p = new ProdutoEx08(50);
        Console.WriteLine($"Antes: {p.Preco:C}");
        p.AplicarDesconto(20);
        Console.WriteLine($"Depois 20%: {p.Preco:C}");
    }
}
