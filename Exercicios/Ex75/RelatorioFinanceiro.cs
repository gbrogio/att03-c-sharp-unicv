namespace Exercicios;

public class RelatorioFinanceiro : RelatorioBase
{
    public override string Titulo => "Financeiro";

    public override void Gerar()
    {
        Console.WriteLine(Cabecalho());
        Console.WriteLine("Conteudo financeiro gerado.");
    }
}
