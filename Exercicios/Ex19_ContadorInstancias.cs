using System;

public class Ex19_ContadorInstancias {
    public static int Contador = 0;

    public Ex19_ContadorInstancias() {
        Contador++;
    }

    public static void ExibirTotal() {
        Console.WriteLine($"Total de instâncias criadas: {Contador}");
    }
}