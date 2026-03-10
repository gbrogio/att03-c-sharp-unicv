using Exercicios.Shared;

namespace Exercicios;

public class ContaOnline : IAutenticavel, INotificavel
{
    public string Usuario { get; }
    private string Senha { get; }

    public ContaOnline(string usuario, string senha)
    {
        Usuario = usuario;
        Senha = senha;
    }

    public bool Autenticar(string senha) => Senha == senha;

    public bool EnviarNotificacao(string mensagem)
    {
        Console.WriteLine($"Notificacao para {Usuario}: {mensagem}");
        return true;
    }
}
