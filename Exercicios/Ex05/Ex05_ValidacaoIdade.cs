namespace Exercicios;

public static class Ex05_ValidacaoIdade
{
    public static void Executar()
    {
        try { var p = new Shared.Pessoa("Eva", -1); Console.WriteLine(p.Apresentar()); } catch (Exception ex) { Console.WriteLine(ex.Message); }
    }
}
