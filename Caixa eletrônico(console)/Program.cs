using Caixa_eletrônico_console_;
using System.Runtime.CompilerServices;

CCorrente conta = new CCorrente("1111",500);
CCorrente c2 = new CCorrente();

void Extrato(CCorrente c)
{
    foreach (Transacao t in c.transacoes)
    {
        Console.Write(t.tipo + " " + t.valor);
        if(t.duplicata != null)
        {
            Console.WriteLine(" DUP: " + t.duplicata.valor + " " + t.duplicata.tipo);
        }
        else
        {
            Console.WriteLine();
        }
    }
    Console.WriteLine("Saldo = " + c.saldo + "================");
}

conta.Depositar(1000);
conta.Transferir(c2, 100);

Console.WriteLine("Extrato da c1: ");
Extrato(conta);

Console.WriteLine("Extrato da c2: ");
Extrato(c2);