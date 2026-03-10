namespace Exercicios;

public static class Ex03_ConstrutorNome
{
    public static void Executar()
    {
        var p = new Shared.Pessoa("Carlos"); Console.WriteLine(p.Apresentar());
    }
}
