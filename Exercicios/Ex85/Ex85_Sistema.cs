using System;
using Exercicios;


namespace Exercicios;
class Ex85_Sistema
{
    public static void Executar()
    {
        Pagamento pagamento = new Pagamento();

        pagamento.valor = 17.50;
        pagamento.tipo = "Pinkeys";

        pagamento.Exibir();
    }
}

