using System;

public class Ex23_PropriedadeCalculada {
    public double Base { get; set; }
    public double Altura { get; set; }
    public double Area => (Base * Altura) / 2;

    public void ExibirDados() {
        Console.WriteLine($"Triângulo: Base {Base}, Altura {Altura} -> Área Total: {Area}");
    }
}