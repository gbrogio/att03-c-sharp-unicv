using System;
using System.Collections.Generic;
using System.Text;

namespace Ex84
{
    class Usuario : IAutenticavel
    {
        private string senha = "JesusIsTheWay";

        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}