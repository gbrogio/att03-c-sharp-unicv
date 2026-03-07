using System;

public class Ex26_MetodoOpcional {
    public void ConfigurarAlerta(string mensagem, ConsoleColor cor = ConsoleColor.Red) {
        Console.ForegroundColor = cor;
        Console.WriteLine($"[ALERTA]: {mensagem}");
        Console.ResetColor();
    }
}