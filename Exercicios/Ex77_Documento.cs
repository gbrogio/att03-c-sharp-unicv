using System;

public class Ex77_Documento : Ex76_IImprimivel
{
    pbulic string Texto { get; set; }

    public Ex77_Documento(string texto)
    {
        Texto = texto;
    }

    public void Imprimir()
    {
        Console.WriteLine(Texto);
    }
}