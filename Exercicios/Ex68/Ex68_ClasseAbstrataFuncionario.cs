namespace Exercicios;

public static class Ex68_ClasseAbstrataFuncionario
{
    public static void Executar()
    {
        Shared.FuncionarioAbstrato f = new Shared.Desenvolvedor("Iris", 100, 20); Console.WriteLine(f.Cargo());
    }
}
