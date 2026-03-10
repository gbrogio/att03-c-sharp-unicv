namespace Exercicios;

public static class Ex83_InterfaceMetodoBool
{
    public static void Executar()
    {
        var val = new ValidadorEx83(); Console.WriteLine(val.Validar());
    }
}


public class ValidadorEx83 : IValidador
{
    public bool Validar() => true;
}
