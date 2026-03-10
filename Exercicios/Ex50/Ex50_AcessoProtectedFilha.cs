namespace Exercicios;

public static class Ex50_AcessoProtectedFilha
{
    public static void Executar()
    {
        var f = new Shared.FuncionarioHeranca("Fabi", "666", 3800); Console.WriteLine(f.ObterDocumentoProtegido());
    }
}
