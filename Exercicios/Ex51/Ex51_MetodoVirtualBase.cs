namespace Exercicios;

public static class Ex51_MetodoVirtualBase
{
    public static void Executar()
    {
        Shared.PessoaHeranca p = new Shared.FuncionarioHeranca("Gui", "777", 3200); Console.WriteLine(p.Descrever());
    }
}
