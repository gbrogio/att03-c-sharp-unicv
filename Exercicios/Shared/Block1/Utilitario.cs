namespace Exercicios.Shared;

public class Utilitario
{
    public int Dobrar(int valor) => valor * 2;
    public string Saudacao(string nome = "Visitante") => $"Ola, {nome}!";
    public string FormatarPessoa(string nome, int idade) => $"{nome} tem {idade} anos.";
}
