namespace Exercicios;

public class Ex36_PolimorfismoLista
{
    public static void Executar()
    {
        List<Animal> animais = new List<Animal> { new Cachorro(), new Gato() };
        foreach (var animal in animais)
        {
            animal.EmitirSom();
        }
    }
}