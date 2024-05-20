using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caixa_eletrônico_console_
{
    public class Transacao
    {
        private double valor;
        private char tipo;
        private Transacao duplicata;
        private Conta Conta;
        public Transacao(double valor, char tipo, Conta conta)
        {
            this.valor = valor;
            this.tipo = tipo;
            this.Conta = conta;
        }
    }
}