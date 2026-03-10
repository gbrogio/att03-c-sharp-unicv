namespace Ex83
{
    class Programa
    {
        static void Main(string[] args)
        {
            Usuario user = new Usuario();

            if (user.Autenticar("1234"))
            {
                Console.WriteLine(user.Autenticar("1234"));
                Console.WriteLine("Acesso liberado!");
            }
            else
            {
                Console.WriteLine("Acesso negado!");
            }
        }
    }
}
