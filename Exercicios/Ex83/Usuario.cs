using System;
using System.Collections.Generic;
using System.Text;

namespace Ex83
{
    class Usuario : IAutenticavel
    {
        private string senha = "1234";
        public bool Autenticar(string senha)
        {
            return this.senha == senha;
        }
    }
}
