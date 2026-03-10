namespace Exercicios;

public static class Ex80_ClienteAutenticavel
{
    public static void Executar()
    {
        var c = new ClienteSistema("cliente", "abc"); Console.WriteLine(c.Autenticar("abc"));
    }
}
