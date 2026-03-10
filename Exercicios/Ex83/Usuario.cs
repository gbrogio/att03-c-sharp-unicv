using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;

class Usuario : IAutenticavel
{
    private string senha = "1234";
    public bool validar(string senha)
    {
        return this.senha == senha;
    }


}

