using System;

namespace Exercicios;

public class ContaBancariaEx09
{
    private double saldo;

    public double Saldo => saldo;

    public ContaBancariaEx09(double saldoInicial = 0)
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

public static class Ex09_10_11_Conta
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 09-11 ---");
        var conta = new ContaBancariaEx09(100);
        Console.WriteLine($"Saldo inicial: {conta.Saldo:C}");
        conta.Depositar(50);
        Console.WriteLine($"Após depósito: {conta.Saldo:C}");

        var saqueOk = conta.Sacar(30);
        Console.WriteLine($"Saque 30 bem-sucedido? {saqueOk}. Saldo: {conta.Saldo:C}");

        var saqueMaior = conta.Sacar(1000);
        Console.WriteLine($"Tentativa sacar maior que saldo: {saqueMaior}. Saldo: {conta.Saldo:C}");
    }
}
