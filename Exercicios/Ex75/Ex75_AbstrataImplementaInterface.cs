namespace Exercicios;

public static class Ex75_AbstrataImplementaInterface
{
    public static void Executar()
    {
        RelatorioBase r = new RelatorioFinanceiro(); r.Gerar();
    }
}
