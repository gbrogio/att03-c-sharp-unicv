using System;
using System.Collections.Generic;
using System.Text;

namespace Ex84
{
    class Sistema
    {
        public void Login(IAutenticavel usuario)
        {
            if (usuario.Autenticar("JesusIsTheWay"))
            {
                Console.WriteLine("Senha: JesusIsTheWay validada! \nAcesso permitido!");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}