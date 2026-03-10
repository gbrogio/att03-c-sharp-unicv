namespace Exercicios;

public static class Ex21_ClasseCarroAcelerar
{
    public static void Executar()
    {
        var c = new Shared.CarroBasico("Gol"); c.Acelerar(); Console.WriteLine(c.Velocidade);
    }
}
