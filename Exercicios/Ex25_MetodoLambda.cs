using System;

public class Ex25_MetodoLambda {
    public bool EhMaiorDeIdade(int idade) => idade >= 18;

    public void Verificar(int idade) {
        string status = EhMaiorDeIdade(idade) ? "Autorizado" : "Negado";
        Console.WriteLine($"Idade {idade}: Acesso {status}.");
    }
}