namespace Exercicios.Shared;

public interface IAutenticavel
{
    string Usuario { get; }
    bool Autenticar(string senha);
}
