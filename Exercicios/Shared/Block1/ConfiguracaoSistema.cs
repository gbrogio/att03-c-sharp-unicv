namespace Exercicios.Shared;

public class ConfiguracaoSistema
{
    public readonly string NomeSistema;
    public const double PI = 3.14159265359;

    public ConfiguracaoSistema(string nomeSistema)
    {
        NomeSistema = nomeSistema;
    }

    public static int Somar(int a, int b) => a + b;
}
