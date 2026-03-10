namespace Exercicios.Shared;

public class Administrador : IAutenticavel
{
    public string Usuario { get; }
    private string Senha { get; }

    public Administrador(string usuario, string senha)
    {
        Usuario = usuario;
        Senha = senha;
    }

    public bool Autenticar(string senha) => Senha == senha;
}
