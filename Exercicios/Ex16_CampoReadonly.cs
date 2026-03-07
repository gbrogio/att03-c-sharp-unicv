using System;

public class Ex16_CampoReadonly{
    public readonly string ChaveIdentificacao;

    public Ex16_CampoReadonly(string chave){
        ChaveIdentificacao = chave;
    }

    public void ExibirChave(){
        Console.WriteLine($"Chave de Identificação: {ChaveIdentificacao}");
    }
}