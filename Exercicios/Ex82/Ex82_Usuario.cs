
using System;
namespace Exercicios;

class Ex82_Usuario
{
    public static void Executar()
    {
        Usuario user = new Usuario { Idade = 23, Nome = "Lucas" };

        user.MostrarDados();
    }
}
