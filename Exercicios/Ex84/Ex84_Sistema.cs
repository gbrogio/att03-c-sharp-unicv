using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicios;
class Ex84_Sistema
{
    public static void Executar()
    {
        Usuario user = new Usuario();
        Sistema sistem = new Sistema();

        sistem.Login(user);
    }
}
