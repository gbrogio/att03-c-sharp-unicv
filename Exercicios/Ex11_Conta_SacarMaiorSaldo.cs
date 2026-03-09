using System;

namespace Exercicios;

public static class Ex11_Conta
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 11 ---");
        var c = new ContaEx10(50);
        var resultado = c.Sacar(100);
        Console.WriteLine($"Tentativa sacar 100 em saldo 50: {resultado}. Saldo: {c.Saldo:C}");
    }
}
