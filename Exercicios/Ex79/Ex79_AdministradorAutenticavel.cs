namespace Exercicios;

public static class Ex79_AdministradorAutenticavel
{
    public static void Executar()
    {
        var a = new Shared.Administrador("admin", "456"); Console.WriteLine(a.Autenticar("456"));
    }
}
