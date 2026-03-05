using System;

public abstract class Ex73_ProtectedConstrutor
{
    public string Nome { get; set; }

    protected Ex73_ProtectedConstrutor(string nome)
    {
        Nome = nome;
    }
}