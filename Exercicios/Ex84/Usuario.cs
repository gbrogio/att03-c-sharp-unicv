using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
class Usuario : IAutenticavel
{
    private string Senha = "JesusIsTheWay";

    public bool Autenticar(string senha)
    {
        return this.Senha == senha;
    }
}
