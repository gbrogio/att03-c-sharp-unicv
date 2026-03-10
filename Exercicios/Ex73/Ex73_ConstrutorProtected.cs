namespace Exercicios;

public static class Ex73_ConstrutorProtected
{
    public static void Executar()
    {
        Shared.FuncionarioAbstrato f = new Shared.Desenvolvedor("Nilo", 90, 10); Console.WriteLine(f.Nome);
    }
}
