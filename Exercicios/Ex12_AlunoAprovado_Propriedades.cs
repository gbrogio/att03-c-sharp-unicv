using System;

namespace Exercicios;

public class AlunoEx12
{
    public double Nota { get; set; }

    public AlunoEx12(double nota)
    {
        Nota = nota;
    }

    public bool Aprovado()
    {
        return Nota >= 7.0;
    }
}

public class AlunoEx14
{
    public string Nome { get; }

    public AlunoEx14(string nome)
    {
        Nome = nome;
    }
}

public class AlunoEx15
{
    public string Nome { get; private set; }

    public AlunoEx15(string nome)
    {
        Nome = nome;
    }

    public void AtualizarNome(string novo)
    {
        Nome = novo;
    }
}

public static class Ex12_13_14_15_Aluno
{
    public static void Executar()
    {
        Console.WriteLine("--- Exercício 12-15 ---");

        var a = new AlunoEx12(8.5);
        Console.WriteLine($"Aluno nota {a.Nota} aprovado? {a.Aprovado()}");

        var a2 = new AlunoEx12(6.0);
        Console.WriteLine($"Aluno nota {a2.Nota} aprovado? {a2.Aprovado()}");

        var somenteLeitura = new AlunoEx14("Paulo");
        Console.WriteLine($"Aluno somente leitura: {somenteLeitura.Nome}");

        var privado = new AlunoEx15("Carla");
        Console.WriteLine($"Nome inicial (private set): {privado.Nome}");
        privado.AtualizarNome("Carla Silva");
        Console.WriteLine($"Nome atualizado: {privado.Nome}");
    }
}
