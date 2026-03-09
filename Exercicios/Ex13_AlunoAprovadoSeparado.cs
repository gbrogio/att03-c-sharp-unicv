using System;

namespace Exercicios;

public class AlunoEx13
{
    public double Nota { get; set; }

    public AlunoEx13(double nota)
    {
        Nota = nota;
    }

    public bool Aprovado()
    {
        return Nota >= 7.0;
    }
}

public static class Ex13_Aluno
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 13 ---");
        var a = new AlunoEx13(7.5);
        Console.WriteLine($"Nota {a.Nota} aprovado? {a.Aprovado()}");

        var b = new AlunoEx13(6.9);
        Console.WriteLine($"Nota {b.Nota} aprovado? {b.Aprovado()}");
    }
}
