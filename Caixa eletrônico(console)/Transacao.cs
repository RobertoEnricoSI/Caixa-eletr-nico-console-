using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_eletrônico_console_
{
    public class Transacao
    {
        public double valor;
        public char tipo;
        public Transacao duplicata;
        public Conta Conta;
        public Transacao(double valor, char tipo, Conta conta)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.Conta = conta;
        }
    }
}