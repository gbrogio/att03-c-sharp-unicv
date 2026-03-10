using Exercicios.Shared;

namespace Exercicios;

public class ClienteSistema : IAutenticavel
{
    public string Usuario { get; }
    private string Senha { get; }

    public ClienteSistema(string usuario, string senha)
    {
        Usuario = usuario;
        Senha = senha;
    }

    public bool Autenticar(string senha) => Senha == senha;
}
