namespace Exercicios.Shared;

public class CarroBasico
{
    public string Modelo { get; }
    public int Velocidade { get; private set; }

    public CarroBasico(string modelo)
    {
        Modelo = modelo;
    }

    public void Acelerar(int incremento = 10)
    {
        Velocidade += incremento;
    }
}
