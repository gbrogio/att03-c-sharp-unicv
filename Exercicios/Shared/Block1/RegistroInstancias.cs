namespace Exercicios.Shared;

public class RegistroInstancias
{
    public static int TotalInstancias { get; private set; }

    public RegistroInstancias()
    {
        TotalInstancias++;
    }

    public override string ToString() => $"Instancia #{TotalInstancias}";
}
