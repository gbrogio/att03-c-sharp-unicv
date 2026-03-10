namespace Exercicios;

public static class Ex13_MetodoAprovado
{
    public static void Executar()
    {
        var a = new Shared.Aluno("Nina", 5.9); Console.WriteLine(a.Aprovado());
    }
}
