using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Exercicios;
public class PagamentoCartao3 : Pagamento3
{
    public PagamentoCartao3(double valor) : base("Cartão", valor) { }
    public override void Processar()
    {
        Console.WriteLine($"Processando pagamento no cartão de R${Valor}");
    }
    
}

