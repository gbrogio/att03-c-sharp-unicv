namespace Exercicios;

public partial class Carro
{
    public override void CalcularConsumo()
    {
        Console.WriteLine("Consumo do Carro: Aproximadamente 12 km/l.");
    }
}

public partial class Moto
{
    public override void CalcularConsumo()
    {
        Console.WriteLine("Consumo da Moto: Aproximadamente 25 km/l.");
    }
}

public class Ex42_SobrescrevaNasFilhas
{
    public static void Executar()
    {
        Carro fusca = new Carro("VW");
        fusca.CalcularConsumo();
    }
}