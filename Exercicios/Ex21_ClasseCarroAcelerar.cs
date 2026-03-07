using System;

public class Ex21_ClasseCarroAcelerar {
    public int VelocidadeAtual { get; private set; } = 0;

    public void Acelerar(int incremento) {
        VelocidadeAtual += incremento;
        Console.WriteLine($"O carro acelerou para {VelocidadeAtual} km/h.");
    }

    public void Frear() {
        VelocidadeAtual = 0;
        Console.WriteLine("O carro parou totalmente.");
    }
}