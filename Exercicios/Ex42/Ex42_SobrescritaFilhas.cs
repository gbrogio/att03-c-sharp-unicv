namespace Exercicios;

public static class Ex42_SobrescritaFilhas
{
    public static void Executar()
    {
        var v1 = new Shared.CarroVeiculo("Toyota"); var v2 = new Shared.Moto("Yamaha"); Console.WriteLine(v1.CalcularConsumo(200, 10)); Console.WriteLine(v2.CalcularConsumo(200, 10));
    }
}
