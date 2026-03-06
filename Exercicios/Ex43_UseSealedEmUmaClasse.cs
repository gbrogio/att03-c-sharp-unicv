namespace Exercicios;

public sealed class SistemaSeguro
{
    public void Mensagem() => Console.WriteLine("Esta classe não pode ser herdada.");
}

public class Ex43_UseSealedEmUmaClasse
{
    public static void Executar() => Console.WriteLine("Classe 'SistemaSeguro' definida como sealed.");
}