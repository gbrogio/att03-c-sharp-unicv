namespace Exercicios.Shared;

public class Pessoa
{
    public string Nome { get; private set; }
    public int Idade { get; private set; }

    public Pessoa(string nome)
    {
        Nome = nome;
    }

    public Pessoa(string nome, int idade) : this(nome)
    {
        DefinirIdade(idade);
    }

    public void DefinirIdade(int idade)
    {
        if (idade < 0)
        {
            throw new ArgumentException("Idade nao pode ser negativa.");
        }

        Idade = idade;
    }

    public string Apresentar() => $"Nome: {Nome}, Idade: {Idade}";
}
