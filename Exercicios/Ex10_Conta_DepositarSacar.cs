using System;

namespace Exercicios;

public class ContaEx10
{
    private double saldo;
    public double Saldo => saldo;

    public ContaEx10(double saldoInicial = 0)
    {
        if (saldoInicial < 0) throw new ArgumentException("Saldo inicial não pode ser negativo.");
        saldo = saldoInicial;
    }

    public void Depositar(double valor)
    {
        if (valor <= 0) throw new ArgumentException("Valor de depósito deve ser maior que zero.");
        saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= 0) return false;
        if (valor > saldo) return false;
        saldo -= valor;
        return true;
    }
}

public static class Ex10_Conta
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 10 ---");
        var c = new ContaEx10(100);
        c.Depositar(50);
        Console.WriteLine($"Saldo após depósito: {c.Saldo:C}");
        var ok = c.Sacar(30);
        Console.WriteLine($"Saque 30 ok? {ok}. Saldo: {c.Saldo:C}");
    }
}
