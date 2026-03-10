namespace Exercicios.Shared;

public class Animal
{
    public string Nome { get; set; } = string.Empty;
    public virtual string EmitirSom() => "Som generico";
}
