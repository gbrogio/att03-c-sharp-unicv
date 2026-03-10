using System;
namespace Exercicios;


class Ex81_Duas_Interfaces : IAutenticavel, IImprimivel
{
    public string Nome { get; set; }
    public double Salario { get; set; }
    public int Idade { get; set; }
    public string Senha { get; set; }

    public bool Autenticar(string senha)
    {
        if (Senha == senha)
        {
            Console.WriteLine($"Senha: {Senha}\nAcesso liberado!");
        }
        else
        {
            Console.WriteLine("Acesso negado!");
        }
        return Senha == senha;
    }

    public void imprimir()
    {
        Console.WriteLine("Exemplo de impressão de documento!");
    }

    public static void Executar()
    {
        Ex81_Duas_Interfaces user = new Ex81_Duas_Interfaces
        {
            Nome = "lucas",
            Idade = 23,
            Senha = "PetrusApostolus",
            Salario = 3.700
        };
    
        user.imprimir();
        user.Autenticar("PetrusApostolus");
    }
}
