namespace Exercicios;

public static class Ex16_CampoReadonly
{
    public static void Executar()
    {
        var conf = new Shared.ConfiguracaoSistema("Lab"); Console.WriteLine(conf.NomeSistema);
    }
}
