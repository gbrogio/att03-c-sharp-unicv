namespace Exercicios;

public static class Ex81_ClasseDuasInterfaces
{
    public static void Executar()
    {
        var c = new ContaOnline("user", "123"); Console.WriteLine(c.Autenticar("123")); c.EnviarNotificacao("Bem-vindo");
    }
}
