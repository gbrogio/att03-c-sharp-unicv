namespace Exercicios;

public static class Ex72_ConstrutorClasseAbstrata
{
    public static void Executar()
    {
        Shared.FuncionarioAbstrato f = new Shared.GerenteAbstrato("Mia", 6000); Console.WriteLine(f.Nome);
    }
}
