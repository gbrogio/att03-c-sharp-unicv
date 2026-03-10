
using System;
namespace Exercicios;

class Ex82_Usuario
{
    static void Executar()
    {
        Usuario user = new Usuario { Idade = 23, Nome = "Lucas" };

        user.MostrarDados();
    }
}
