namespace Exercicios;

public static class Ex30_EncapsulamentoFuncionario
{
    public static void Executar()
    {
        var f = new FuncionarioEncapsulado("Rafa", 3000); f.AumentarSalario(10); Console.WriteLine(f);
    }
}
