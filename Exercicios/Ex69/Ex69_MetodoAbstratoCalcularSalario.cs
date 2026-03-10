namespace Exercicios;

public static class Ex69_MetodoAbstratoCalcularSalario
{
    public static void Executar()
    {
        Shared.FuncionarioAbstrato f = new Shared.Desenvolvedor("Jo", 120, 25); Console.WriteLine(f.CalcularSalario());
    }
}
