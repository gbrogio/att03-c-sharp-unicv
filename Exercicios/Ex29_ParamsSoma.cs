using System;
using System.Linq;

public class Ex29_ParamsSoma {
    public void GerarRelatorio(string titulo, params double[] valores) {
        double total = valores.Sum();
        Console.WriteLine($"Itens processados: {valores.Length}");
        Console.WriteLine($"Soma total: {total:C2}");
    }
}