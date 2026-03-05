using System;

public class Ex79_Administrator : Ex78_IAutenticavel
{
    private string Senha {  get; set; }

    public Ex79_Administrator(string senha)
    {
        Senha = senha;
    }

    public bool Autenticar(string senha)
    {
        return Senha == senha;
    }
}