using System;

public class Ex28_MetodoComRef {
    public void AplicarTaxa(ref double saldo, double taxa) {
        saldo += (saldo * (taxa / 100));
        Console.WriteLine("Taxa aplicada com sucesso ao saldo original.");
    }
}