namespace Exercicios;

public static class Ex46_FuncionarioHerdandoPessoa
{
    public static void Executar()
    {
        var f = new Shared.FuncionarioHeranca("Bia", "222", 4000); Console.WriteLine(f.Descrever());
    }
}
