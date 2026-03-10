namespace Exercicios.Shared;

public class Aluno
{
    public string Nome { get; set; }
    public double Nota { get; private set; }

    public Aluno(string nome, double nota)
    {
        Nome = nome;
        Nota = nota;
    }

    public bool Aprovado() => Nota >= 6.0;
}
