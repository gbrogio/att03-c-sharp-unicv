namespace Exercicios;

public static class Ex49_ProtectedAtributo
{
    public static void Executar()
    {
        var f = new Shared.FuncionarioHeranca("Eli", "555", 3500); Console.WriteLine(f.ObterDocumentoProtegido());
    }
}
