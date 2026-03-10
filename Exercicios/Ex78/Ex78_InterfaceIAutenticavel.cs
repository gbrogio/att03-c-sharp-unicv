namespace Exercicios;

public static class Ex78_InterfaceIAutenticavel
{
    public static void Executar()
    {
        Shared.IAutenticavel a = new Shared.Administrador("root", "123"); Console.WriteLine(a.Autenticar("123"));
    }
}
