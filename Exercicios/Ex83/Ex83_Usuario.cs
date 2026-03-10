namespace Exercicios;

class EX83_Usuario
{
    public static void Executar()
    {
        Usuario user = new Usuario();

        if (user.validar("1234"))
        {
            Console.WriteLine(user.validar("1234"));
            Console.WriteLine("Acesso liberado!");
        }
        else
        {
            Console.WriteLine("Acesso negado!");
        }
    }
}

