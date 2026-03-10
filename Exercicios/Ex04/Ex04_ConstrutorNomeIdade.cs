namespace Exercicios;

public static class Ex04_ConstrutorNomeIdade
{
    public static void Executar()
    {
        var p = new Shared.Pessoa("Duda", 25); Console.WriteLine(p.Apresentar());
    }
}
