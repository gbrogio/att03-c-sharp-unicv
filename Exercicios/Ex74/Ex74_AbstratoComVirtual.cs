namespace Exercicios;

public static class Ex74_AbstratoComVirtual
{
    public static void Executar()
    {
        Shared.FuncionarioAbstrato f = new Shared.GerenteAbstrato("Otto", 8000); Console.WriteLine(f.Cargo()); Console.WriteLine(f.CalcularSalario());
    }
}
