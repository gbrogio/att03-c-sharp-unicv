using System;

public class Ex30_ConstrutorCadeia {
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double Salario { get; set; }

    public Ex30_ConstrutorCadeia(string nome, string cargo, double salario) {
        this.Nome = nome;
        this.Cargo = cargo;
        this.Salario = salario;
    }

    public Ex30_ConstrutorCadeia(string nome) : this(nome, "Estagiário", 1200.00) {
        Console.WriteLine("Novo funcionário registrado como padrão.");
    }
}