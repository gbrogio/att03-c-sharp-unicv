using System;

public class Ex22_UsoDoThis {
    private string descricao;

    public Ex22_UsoDoThis(string descricao) {
        this.descricao = descricao;
    }

    public void AlterarDescricao(string descricao) {
        this.descricao = descricao;
    }

    public void Mostrar() => Console.WriteLine($"Descrição: {this.descricao}");
}