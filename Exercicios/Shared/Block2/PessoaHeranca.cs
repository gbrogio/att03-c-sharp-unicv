namespace Exercicios.Shared;

public class PessoaHeranca
{
    protected string Documento;
    public string Nome { get; }

    public PessoaHeranca(string nome, string documento)
    {
        Nome = nome;
        Documento = documento;
    }

    public virtual string Descrever() => $"Pessoa: {Nome}";
}
